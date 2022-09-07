using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;

using Entities;
using Models;

namespace Controllers
{
	public class AdmittedPatientController
	{
		static AdmittedPatientModel objAdmittedPatientModel = new AdmittedPatientModel();

		public static List<AdmittedPatientEntity> AdmittedPatientSelectAll()
		{
			objAdmittedPatientModel = new AdmittedPatientModel();
			return objAdmittedPatientModel.AdmittedPatientSelectAll();
		}

		public static AdmittedPatientEntity AdmittedPatientSelectByID(long patient_id)
		{
			objAdmittedPatientModel = new AdmittedPatientModel();
			return objAdmittedPatientModel.SelectAdmittedPatientByID(patient_id);
		}

		public static List<AdmittedPatientEntity> SelectAdmittedPatient(string cnic, string phone)
		{
			List<AdmittedPatientEntity> admitted_patients = new List<AdmittedPatientEntity>();
			if (admitted_patients != null)
			{
				List<AdmittedPatientEntity> selected_patients = admitted_patients.FindAll(patient => patient.PatientCNIC == cnic && patient.AttendentPhone == phone);
				return selected_patients;
			}
			return null;
		}

		/// <summary>
		/// This function will call Model function to Add or Update new patient in Admitted Patient
		/// </summary>
		/// <param name="objAdmittedPatient"></param>
		/// <returns>Newly admitted patient</returns>
		public static long InsertUpdateAdmittedPatient(AdmittedPatientEntity objAdmittedPatient)
		{
			objAdmittedPatientModel = new AdmittedPatientModel();
			long new_id = objAdmittedPatientModel.InsertUpdateAdmittedPatient(objAdmittedPatient);
			return new_id;
		}

		public static void UploadPatients()
		{
			List<AdmittedPatientEntity> un_uploaded_patients = GetUnUploadedPatients();

			foreach (AdmittedPatientEntity un_uploaded_patient in un_uploaded_patients)
			{
				JObject patient_json = new JObject();
				JProperty[] properties = new JProperty[6];
				properties[0] = new JProperty("fullname", un_uploaded_patient.PatientName);
				properties[1] = new JProperty("password", "12345678");
				properties[2] = new JProperty("cnic", un_uploaded_patient.PatientCNIC);
				properties[3] = new JProperty("phone", un_uploaded_patient.AttendentPhone);
				properties[4] = new JProperty("city", un_uploaded_patient.PatientAddress);
				properties[5] = new JProperty("gender", un_uploaded_patient.PatientGender);

				foreach (JProperty property in properties)
					patient_json.Add(property);

				HttpWebRequest patient_register_request = (HttpWebRequest)WebRequest.Create(@"https://safe-rh-mis.com/register/");
				patient_register_request.Timeout = 20000;


				patient_register_request.Method = "POST";
				patient_register_request.ContentType = "application/json";
				patient_register_request.ContentLength = patient_json.ToString().Length;
				Stream patient_reg_post = patient_register_request.GetRequestStream();
				byte[] patient_bin_data = Encoding.ASCII.GetBytes(patient_json.ToString());
				patient_reg_post.Write(patient_bin_data, 0, patient_bin_data.Length);
				patient_reg_post.Close();

				WebResponse web_res = patient_register_request.GetResponse();
				Stream reg_reader = web_res.GetResponseStream();
				byte[] reg_buffer = new byte[1024];
				reg_reader.Read(reg_buffer, 0, 1024);
				string reg_data = Encoding.ASCII.GetString(reg_buffer);
				JObject reg_json = JObject.Parse(reg_data);
				string code_value = ((Newtonsoft.Json.Linq.JProperty)reg_json.Last).Value.ToString();
				if (code_value == "201")
				{
					string url = "http://safe-rh-mis.com/logIn/";
					JObject patient_login = new JObject();
					patient_login.Add(properties[3]);
					patient_login.Add(properties[1]);
					string login_data = patient_login.ToString();

					HttpWebRequest login_req = (HttpWebRequest)WebRequest.Create(url);
					byte[] data = Encoding.ASCII.GetBytes(login_data);
					login_req.Method = "POST";
					login_req.ContentType = "application/json";
					login_req.ContentLength = data.Length;
					Stream login_post_data = login_req.GetRequestStream();
					login_post_data.Write(data, 0, data.Length);
					login_post_data.Close();

					WebResponse login_res = login_req.GetResponse();
					Stream reader = login_res.GetResponseStream();
					byte[] buffer = new byte[1024];
					reader.Read(buffer, 0, 1024);
					string patient_data = Encoding.ASCII.GetString(buffer);
					JObject patient_arr = JObject.Parse(patient_data);
					long global_id = (long)((JProperty)JObject.Parse(patient_data).Last).Value;

					un_uploaded_patient.GlobalPatientID = global_id;
					long id = AdmittedPatientController.InsertUpdateAdmittedPatient(un_uploaded_patient);
				}


			}
		}

		public static List<AdmittedPatientEntity> GetUnUploadedPatients()
		{
			List<AdmittedPatientEntity> all_patients = AdmittedPatientSelectAll();
			List<AdmittedPatientEntity> un_uploaded_patients = new List<AdmittedPatientEntity>();
			un_uploaded_patients = all_patients.FindAll(p => p.GlobalPatientID == 0);
			return un_uploaded_patients;
		}

		public static List<AdmittedPatientEntity> GetPatientByPhoneOrCNIC(string search_string)
		{
			List<AdmittedPatientEntity> all_patiens = AdmittedPatientSelectAll();
			List<AdmittedPatientEntity> selected_patients = all_patiens.FindAll(p => p.PatientCNIC == search_string || p.AttendentPhone == search_string);
			return selected_patients;
		}

		public static List<AdmittedPatientEntity> GetTodayPatients()
		{
			List<AdmittedPatientEntity> all_patients = AdmittedPatientSelectAll();
			List<AdmittedPatientEntity> today_current_patients = all_patients.FindAll(p => p.AdmissionDate.Date == DateTime.Today);
			return today_current_patients;
		}
	}
}
