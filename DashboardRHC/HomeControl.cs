using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Entities;
using Controllers;


namespace DashboardRHC
{
    public partial class HomeControl : UserControl
    {
        public string DeviceID { get; set; }
        public int tryout = 0;
        BackgroundWorker data_collector;
        string rec_data;
        bool is_connected = false;
        string device_name = "";
        string patient_name = "";
        int x = 50, y = 20;
        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            int patient_count = AdmittedPatientController.AdmittedPatientSelectAll().Count;
            int device_count = DeviceController.DeviceSelectAll().Count;
            int staff_count = StaffRHCController.StaffRHCSelectAll().Count;

            lblPatientCountValue.Text = patient_count.ToString();
            lblDevcesCountValue.Text = device_count.ToString();
            lblStaffCountValue.Text = staff_count.ToString();
            CollectData();
        }

        private void picStaff_Click(object sender, EventArgs e)
        {

        }

        private void pnlHomeBody_Paint(object sender, PaintEventArgs e)
        {





        }

        private void CollectData()
        {
            try
            {
                pnlHomeBody.Controls.Clear();
                List<DeviceAttachmentEntity> attached_devices = DeviceAttachmentController.DeviceAttachmentSelectAll();
                foreach (DeviceAttachmentEntity attached_device in attached_devices)
                {
                    DeviceEntity device = DeviceController.DeviceSelectByID(Convert.ToInt32(attached_device.DeviceID));
                    device_name = device.DeviceName;
                    patient_name = AdmittedPatientController.AdmittedPatientSelectByID(Convert.ToInt32(attached_device.PatientID)).PatientName;

                    PatientInsightBox patient_box = new PatientInsightBox();

                    patient_box.Location = new Point(x, y);
                    patient_box.AttachedDevice = attached_device;
                    //patient_box.DeviceURL = device.DeviceIP;
                    //patient_box.DeviceName = device_name;
                    //patient_box.PatientName = patient_name;
                    //patient_box.PatientID = attached_device.PatientID;
                    //patient_box.DeviceID = attached_device.DeviceID;
                    
                    pnlHomeBody.Controls.Add(patient_box);

                    x += 220;
                    if (x > 500)
                    {
                        x = 50;
                        y += 70;
                    }

                
                }
            }
            catch (WebException ex)
            { 
                
            }
        }
    }
}
