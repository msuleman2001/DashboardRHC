using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using Entities;
using Controllers;

namespace DataCollectionService
{
    public class PatientDataCollector
    {
        private readonly System.Timers.Timer service_timer;
        public long ElapsedTime = 10000;
        string server_address = "https://10.122.44.155:8000//";

        //Service functions
        public PatientDataCollector()
        {
            service_timer = new System.Timers.Timer(ElapsedTime) { AutoReset = true};
            service_timer.Elapsed += CollectData;
        }

        public void Start()
        { service_timer.Start(); }

        public void Stop()
        { service_timer.Stop(); }

        //Operations
        public void CollectData(object sender, System.Timers.ElapsedEventArgs e)
        {
            FetchAndStoreDeviceData();
            //Thread listen on port 55600 collect node infos. 
            // It will added into shared datastructure. 
            // It will be added to database as well.

            UploadPatientInfo();

        }

        /// <summary>
        /// This function will fetch data from device and store it into local database
        /// </summary>
        private void FetchAndStoreDeviceData()
        {

            List<DeviceAttachmentEntity> attached_devices = DeviceAttachmentController.DeviceAttachmentSelectAll();

            foreach (DeviceAttachmentEntity attached_device in attached_devices)
            {
                try
                {
                    DeviceEntity device = DeviceController.DeviceSelectByID(attached_device.DeviceID);

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://" + device.DeviceIP);
                    request.Timeout = 2000;
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    string rec_data = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    response.Close();
                    string[] data_values = rec_data.Split(',');
                    SaveDataToDatabase(data_values, attached_device.PatientID, attached_device.DeviceID);
                }
                catch (Exception ex)
                {
                    //EventLog error_log = new EventLog("DashboardRHC: Device Network Connection Error");
                    //error_log.WriteEntry(ex.Message);
                }
            }
        }

        /// <summary>
        /// This function will upload the data of all Patients to MIS server and get Global Patient ID to store in local database
        /// </summary>
        private void UploadPatientInfo()
        {
            List<AdmittedPatientEntity> unuploaded_patients = AdmittedPatientController.GetUnUploadedPatients();
            foreach (AdmittedPatientEntity unuploaded_patient in unuploaded_patients)
            {                
                JObject patient_data = new JObject();
                patient_data.Add(new JProperty("fullname", unuploaded_patient.PatientName));
                patient_data.Add(new JProperty("password", "123454678"));
                patient_data.Add(new JProperty("cnic", unuploaded_patient.PatientCNIC));
                patient_data.Add(new JProperty("phone", unuploaded_patient.AttendentPhone));
                patient_data.Add(new JProperty("city", unuploaded_patient.PatientAddress));
                patient_data.Add(new JProperty("gender", unuploaded_patient.PatientGender));

                string reg_response = CallAPI(server_address + "register//", patient_data, "POST");

                JObject register_response = JObject.Parse(reg_response);
                string res_code = register_response.Property("code").Value.ToString();
                
                if (res_code == "201")
                {
                    JObject patient_login_json = new JObject();
                    patient_login_json.Add(new JProperty("phone", unuploaded_patient.AttendentPhone));
                    patient_login_json.Add(new JProperty("password", "12345678"));

                    string login_response = CallAPI(server_address + "logIn//", patient_login_json, "POST");
                    JObject login_json = JObject.Parse(login_response);
                    string str_global_id = login_json.Property("id").Value.ToString();
                    
                    unuploaded_patient.GlobalPatientID = Convert.ToInt32(str_global_id);
                    AdmittedPatientController.InsertUpdateAdmittedPatient(unuploaded_patient);
                }
            }
        }

        /// <summary>
        /// API Call requies multiple time in Patients uploading and their data into MIS server
        /// </summary>
        /// <param name="url">URL of API</param>
        /// <param name="json_param">JSON data to server</param>
        /// <param name="method">Method of call</param>
        /// <returns>Response of Server JSON string</returns>
        private string CallAPI(string url, JObject json_param, string method)
        {
            HttpWebRequest api_request = (HttpWebRequest)WebRequest.Create(url);
            api_request.Timeout = 3000;
            api_request.Method = method;
            api_request.ContentType = "application/json";
            api_request.ContentLength = json_param.ToString().Length;

            StreamWriter api_wirtter = new StreamWriter(api_request.GetRequestStream());
            api_wirtter.Write(json_param.ToString());
            api_wirtter.Flush();

            HttpWebResponse api_response = (HttpWebResponse)api_request.GetResponse();

            string response_str = new StreamReader(api_response.GetResponseStream()).ReadToEnd();
            return response_str;

        }

        /// <summary>
        /// Storing data to local database
        /// </summary>
        /// <param name="values">Values from device</param>
        /// <param name="patient_id">PatientID</param>
        /// <param name="device_id">DeviceID</param>
        private void SaveDataToDatabase(string[] values, long patient_id, long device_id)
        {
            long devie_reading_id = 0;

            string values_json = "{\"device_name\":\"" + values[0] + "\", \"body_temp\": \" " + values[2] + "\", \"o2\": \"" + values[3] + "\", \"heart_rate\": \"" + values[4] + " \", \"envo_hum\": \"" + values[5] + "\", \"envo_temp\": \"" + values[6] + "\"}";

            DeviceReadingsEntity reading = new DeviceReadingsEntity();
            reading.DeviceReadingID = 0;
            reading.DeviceID = device_id;
            reading.PatientID = patient_id;
            reading.ReadingValuesJSON = values_json;
            reading.IsUploaded = Convert.ToString(false);
            reading.CreatedDateTime = DateTime.Now;
            reading.Remarks = "NA";

            devie_reading_id = DeviceReadingsController.DeviceReadingInsertUpdate(reading);

            if (devie_reading_id == 0)
            {
                //EventLog error_log = new EventLog("DashboardRHC: Database Entry Error ");
                //error_log.WriteEntry("Undable to write data into Database");
            }
        }
    }
}
