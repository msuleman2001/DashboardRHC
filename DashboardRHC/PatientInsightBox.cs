using System;
using System.IO;
using System.Net;
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
    public partial class PatientInsightBox : UserControl
    {
        public DeviceAttachmentEntity AttachedDevice { get; set; }

        DeviceReadingsEntity device_reading;
        public PatientInsightBox()
        {
            InitializeComponent();
        }

        private void lblPatientName_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = (frmDashboard) this.FindForm();
            string[] args = { lblPatientName.Text };
        }

        private void tmrDataRequest_Tick(object sender, EventArgs e)
        {
            //await Task.Run(() => DeviceReading());
            DeviceReadingsEntity device_reading = DeviceReadingsController.GetLatestPatientReading(AttachedDevice.PatientID);
            if (device_reading == null)
                return;
            
            lblDeviceName.Text = DeviceController.DeviceSelectByID(device_reading.DeviceID).DeviceName;
            lblPatientName.Text = AdmittedPatientController.AdmittedPatientSelectByID(device_reading.PatientID).PatientName;
            JObject readings = JObject.Parse(device_reading.ReadingValuesJSON);
            lblBodyTemperature.Text = "Body Temperature: " + readings["body_temp"].ToString();
            lblO2Saturation.Text = "O2 - HR: " + readings["o2"].ToString() + " - " + readings["heart_rate"].ToString();
            lblEnvHumidity.Text = "Environment Humidity: " + readings["envo_hum"].ToString();
            lblEnvTemp.Text = "Environment Temperature: " + readings["envo_temp"].ToString();
            
            //DeviceEntity device = DeviceController.DeviceSelectByID(AttachedDevice.DeviceID);
            //AdmittedPatientEntity patient = AdmittedPatientController.AdmittedPatientSelectByID(AttachedDevice.DeviceID);
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://" + device.DeviceIP);
            //request.Timeout = 1000;
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //string rec_data = new StreamReader(response.GetResponseStream()).ReadToEnd();

            //string[] data_values = rec_data.Split(',');
            //lblDeviceID.Text = device.DeviceName;
            //lblPatientName.Text = patient.PatientName;
            //lblBodyTemperature.Text = "Temperature: " + data_values[2];
            //lblO2Saturation.Text = "O2 - Heart Rate: " + data_values[3] + "-" + data_values[4];
            //lblEnvHumidity.Text = "Env Humidity: " + data_values[5];
            //lblEnvTemp.Text = "Environment Temp: " + data_values[6];
        }

        void DeviceReading()
        {
            DeviceReadingsEntity device_reading = DeviceReadingsController.GetLatestPatientReading(AttachedDevice.PatientID);
        }
    }
}
