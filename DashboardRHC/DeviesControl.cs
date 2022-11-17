using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using Controllers;
using System.Net.Sockets;
using System.Net;

namespace DashboardRHC
{
    public partial class DeviesControl : UserControl
    {
        long device_attach_id;
        string ip_address = "";
        string mac_address = "";
        string device_name = "";
        string device_port = "";
        long current_patient_id = 0;
        long current_attach_device_id = 0;

        public DeviesControl()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DeviceEntity device = new DeviceEntity();
            device.DeviceID = Convert.ToInt32(this.Tag);
            device.DeviceName = txtDeviceName.Text;
            device.Sensors = txtSensors.Text;
            device.DeviceRecievedByID = Program.AdminID;
            device.DeviceRecievedDateTime = DateTime.Now;
            device.DeviceDisableDate = DateTime.Now;
            device.Remarks = txtRemarks.Text;
            if (DeviceController.InsertUpdateDevice(device) > 0)
            {
                MessageBox.Show("Data Saved");
                ClearFields();
            }
                
            else
                MessageBox.Show("Unable to save data");
        }

        private void ClearFields()
        {
            this.Tag = 0;
            txtDeviceName.Text = "";
            txtSensors.Text = "";
            txtRemarks.Text = "";
        }

        private void DeviesControl_Load(object sender, EventArgs e)
        {
            dgvDeviceList.AutoGenerateColumns = false;
            dgvDeviceList.DataSource = DeviceController.DeviceSelectAll();

            cmbDevice.DataSource = dgvDeviceList.DataSource;
            cmbDevice.DisplayMember = "DeviceName";
            cmbDevice.ValueMember = "DeviceID";

            cmbPatient.DataSource = AdmittedPatientController.GetTodayPatients();
            cmbPatient.DisplayMember = "PatientName";
            cmbPatient.ValueMember = "PatientID";

            LoadDeviceInfo(Convert.ToInt32(cmbDevice.SelectedValue));
        }

        private void tabDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDeviceList.AutoGenerateColumns = false;
            dgvDeviceList.DataSource = DeviceController.DeviceSelectAll();
        }

        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDeviceInfo(Convert.ToInt32(cmbDevice.SelectedValue));
                current_attach_device_id = Convert.ToInt64(cmbDevice.SelectedValue);
            }
            catch (Exception ex)
            {
                
            }
        }

        //getting device info
        private void LoadDeviceInfo(int device_id)
        {
            if (device_id == 0)
                return;
            DeviceEntity device = DeviceController.DeviceSelectByID(device_id);
            lblDeviceProperties.Text = device.Sensors + Environment.NewLine + device.DeviceMAC + Environment.NewLine + device.DeviceIP;
            device_attach_id = DeviceAttachmentController.GetAttachedDevice(device_id);

            if (device_attach_id != 0)
            {
                btnAttachDevice.Enabled = false;
                btnDetach.Enabled = true;
            }
            else
            {
                btnAttachDevice.Enabled = true;
                btnDetach.Enabled = false;
            }
        }

        private void btnAttachDevice_Click(object sender, EventArgs e)
        {
            current_attach_device_id = Convert.ToInt64(cmbDevice.SelectedValue);

            //Task.Run(DeviceConnection);
            DeviceConnection();
            DeviceAttachmentEntity device_attachment = new DeviceAttachmentEntity();
            device_attachment.AttachByID = Program.AdminID;
            device_attachment.DeviceID = current_attach_device_id;
            device_attachment.PatientID = Convert.ToInt32(cmbPatient.SelectedValue);
            device_attachment.AttachByID = Program.AdminID;
            device_attachment.AttachmentDateTime = DateTime.Now;
            device_attachment.DetachmentDateTime = DateTime.Now;
            device_attachment.DetachByID = device_attachment.AttachByID;
            device_attachment.Remarks = "NA";

            if (DeviceAttachmentController.InsertUpdateDeviceAttachment(device_attachment) > 0)
            {
                MessageBox.Show("Device Attached");
                btnDetach.Enabled = true;
                btnAttachDevice.Enabled = false;
            }
                
            else
                MessageBox.Show("Unable to attach device");
        }

        void DeviceConnection()
        {
            int listner_port = 55600;
            using (UdpClient udp_client = new UdpClient(listner_port))
            {
                Action label_writter;
                IPEndPoint ip_end_point = new IPEndPoint(IPAddress.Any, listner_port);
                byte[] buffer = new byte[1024];
                while (true)
                {
                    udp_client.Client.ReceiveTimeout = 5000;
                    try
                    {
                        buffer = udp_client.Receive(ref ip_end_point);
                    }
                    catch (System.Net.Sockets.SocketException ex)
                    {
                        return;
                    }

                    string device_data = Encoding.ASCII.GetString(buffer, 0, buffer.Length);
                    string[] data_items = device_data.Split(';');
                    ip_address = data_items[0].Split('|')[1];
                    device_port = data_items[1].Split('|')[1];
                    mac_address = data_items[2].Split('|')[1];
                    device_name = data_items[3].Split('|')[1];
                    label_writter = delegate { UpdateLable(device_data + Environment.NewLine); };
                    lblAttachmentInfo.Invoke(label_writter);
                    byte[] sendData = Encoding.ASCII.GetBytes("RHC_ACCEPTED");
                    udp_client.Send(sendData, sendData.Length, ip_end_point);

                    UpdateDevice();
                }
            }
        }

        void UpdateDevice()
        {
            DeviceEntity device = DeviceController.DeviceSelectByID(current_attach_device_id);
            device.DeviceIP = ip_address;
            device.DeviceMAC = mac_address;
            device.DevicePort = device_port;
            DeviceController.InsertUpdateDevice(device);
        }

        void UpdateLable(string text)
        {
            lblAttachmentInfo.Text = text;  
        }

        private void dgvDeviceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            if (device_attach_id != 0)
            {
                DeviceAttachmentController.DeleteDeviceAttachmentByID(device_attach_id);
                MessageBox.Show("Device detached");
                btnAttachDevice.Enabled = true;
                btnDetach.Enabled = false;
            }
        }
    }
}
