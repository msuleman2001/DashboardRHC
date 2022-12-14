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
using System.Text.RegularExpressions;

namespace DashboardRHC
{
    public partial class DeviesControl : UserControl
    {
        long device_attach_id;
        public DeviesControl()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDeviceName.Text == "")
            {
                MessageBox.Show("Please Enter Device Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(txtDeviceName.Text, "[a-zA-Z0-9]*$").Success)
            {
                MessageBox.Show("Please Enter a Valid Device Name." +
                    "\n\nHint: Avoid Special Characters.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDeviceName.Focus();
                return;
            }

            if (txtMACAddress.Text == "")
            {
                MessageBox.Show("Please Enter MAC Address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(txtMACAddress.Text, "[a-zA-Z0-9]*$").Success)
            {
                MessageBox.Show("Please Enter a Valid MAC Address." +
                    "\n\nHint: Avoid Special Characters.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMACAddress.Focus();
                return;
            }
            if (txtDeviceIP.Text.Length < 15)
            {
                MessageBox.Show("Please Enter Device IP.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSensors.Text == "")
            {
                MessageBox.Show("Please Enter Sensor Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DeviceEntity device = new DeviceEntity();
            device.DeviceID = Convert.ToInt32(this.Tag);
            device.DeviceName = txtDeviceName.Text;
            device.DeviceMAC = txtMACAddress.Text;
            device.DeviceIP = txtDeviceIP.Text;
            device.Sensors = txtSensors.Text;
            device.DeviceRecievedByID = Program.AdminID;
            device.DeviceRecievedDateTime = DateTime.Now;
            device.IsEnabled = chkIsEnabled.Checked.ToString();
            device.DeviceDisableDate = DateTime.Now;
            device.Remarks = txtRemarks.Text;
            if (DeviceController.InsertUpdateDevice(device) > 0)
            {
                MessageBox.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
                
            else
                MessageBox.Show("Unable to save data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearFields()
        {
            this.Tag = 0;
            txtDeviceName.Text = "";
            txtMACAddress.Text = "";
            txtDeviceIP.Text = "";
            txtSensors.Text = "";
            chkIsEnabled.Checked = false;
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
            }
            catch (Exception ex)
            {
                
            }
        }

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
            DeviceAttachmentEntity device_attachment = new DeviceAttachmentEntity();
            device_attachment.AttachByID = Program.AdminID;
            device_attachment.DeviceID = Convert.ToInt32(cmbDevice.SelectedValue);
            device_attachment.PatientID = Convert.ToInt32(cmbPatient.SelectedValue);
            device_attachment.AttachByID = Program.AdminID;
            device_attachment.AttachmentDateTime = DateTime.Now;
            device_attachment.DetachmentDateTime = DateTime.Now;
            device_attachment.DetachByID = device_attachment.AttachByID;
            device_attachment.Remarks = "NA";

            if (DeviceAttachmentController.InsertUpdateDeviceAttachment(device_attachment) > 0)
            {
                MessageBox.Show("Device Attached", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDetach.Enabled = true;
                btnAttachDevice.Enabled = false;
            }
                
            else
                MessageBox.Show("Unable to attach device", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvDeviceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            if (device_attach_id != 0)
            {
                DeviceAttachmentController.DeleteDeviceAttachmentByID(device_attach_id);
                MessageBox.Show("Device detached", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAttachDevice.Enabled = true;
                btnDetach.Enabled = false;
            }
        }
    }
}
