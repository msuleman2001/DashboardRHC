using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class AdmittedPatientModel
    {
        string connection_string;
        long patient_i_d = 0;
        int records_updated = 0;

        List<AdmittedPatientEntity> admitted_patient_list = new List<AdmittedPatientEntity>();
        AdmittedPatientEntity admitted_patient = new AdmittedPatientEntity();

        OleDbConnection con_admitted_patient;
        OleDbCommand com_admitted_patient;
        OleDbDataAdapter da_admitted_patient;
        DataTable dt_admitted_patient;

        public AdmittedPatientModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_admitted_patient = new OleDbConnection(connection_string);
            com_admitted_patient = new OleDbCommand();
            da_admitted_patient = new OleDbDataAdapter();
            dt_admitted_patient = new DataTable();
        }

        private AdmittedPatientEntity GetEntityTableMap(DataRow dr_admitted_patient)
        {
            AdmittedPatientEntity admitted_patient = new AdmittedPatientEntity();
            admitted_patient.PatientID = Convert.ToInt64(dr_admitted_patient["PatientID"]);
            admitted_patient.GlobalPatientID = Convert.ToInt64(dr_admitted_patient["GlobalPatientID"]);
            admitted_patient.PatientName = Convert.ToString(dr_admitted_patient["PatientName"]);
            admitted_patient.AttendentName = Convert.ToString(dr_admitted_patient["AttendentName"]);
            admitted_patient.PatientCNIC = Convert.ToString(dr_admitted_patient["PatientCNIC"]);
            admitted_patient.AttendentPhone = Convert.ToString(dr_admitted_patient["AttendentPhone"]);
            admitted_patient.PatientAddress = Convert.ToString(dr_admitted_patient["PatientAddress"]);
            admitted_patient.PatientDOB = Convert.ToDateTime(dr_admitted_patient["PatientDOB"]);
            admitted_patient.PatientGender = Convert.ToString(dr_admitted_patient["PatientGender"]);
            admitted_patient.AdmissionDate = Convert.ToDateTime(dr_admitted_patient["AdmissionDate"]);
            admitted_patient.AdmittedByID = Convert.ToInt64(dr_admitted_patient["AdmittedByID"]);
            admitted_patient.DischargeDateTime = Convert.ToDateTime(dr_admitted_patient["DischargeDateTime"]);
            admitted_patient.DischargeAdminID = Convert.ToInt64(dr_admitted_patient["DischargeAdminID"]);
            admitted_patient.Remarks = Convert.ToString(dr_admitted_patient["Remarks"]);

            return admitted_patient;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_admitted_patient.State == ConnectionState.Open)
                    con_admitted_patient.Close();

                con_admitted_patient.Open();
                com_admitted_patient.CommandText = query;
                com_admitted_patient.Connection = con_admitted_patient;

                if (query.StartsWith("SELECT"))
                {
                    da_admitted_patient.SelectCommand = com_admitted_patient;
                    dt_admitted_patient.Clear();
                    da_admitted_patient.Fill(dt_admitted_patient);
                }
                else
                    records_updated = com_admitted_patient.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_admitted_patient = new DataTable();
                records_updated = 0;
            }
        }

        public List<AdmittedPatientEntity> AdmittedPatientSelectAll()
        {
            string query = "SELECT * FROM AdmittedPatient";
            admitted_patient_list.Clear();
            ConnectAndExecute(query);
            if (dt_admitted_patient.Rows.Count > 0)
                foreach (DataRow dr_admitted_patient in dt_admitted_patient.Rows)
                {
                    admitted_patient = GetEntityTableMap(dr_admitted_patient);
                    admitted_patient_list.Add(admitted_patient);
                }

            return admitted_patient_list;
        }

        public AdmittedPatientEntity SelectAdmittedPatientByID(long patient_i_d)
        {
            admitted_patient = new AdmittedPatientEntity();
            string query = "SELECT * FROM AdmittedPatient WHERE PatientID = " + patient_i_d;
            ConnectAndExecute(query);

            if (dt_admitted_patient.Rows.Count > 0)
                admitted_patient = GetEntityTableMap(dt_admitted_patient.Rows[0]);

            return admitted_patient;
        }

        public long InsertUpdateAdmittedPatient(AdmittedPatientEntity admitted_patient)
        {
            string query = "";
            long patient_i_d = admitted_patient.PatientID;
            AdmittedPatientEntity existed_admitted_patient = SelectAdmittedPatientByID(patient_i_d);

            if (existed_admitted_patient.PatientID == 0)
            {
                query = "INSERT INTO AdmittedPatient (GlobalPatientID,PatientName,AttendentName,PatientCNIC,AttendentPhone,PatientAddress,PatientDOB,PatientGender,AdmissionDate,AdmittedByID,DischargeDateTime,DischargeAdminID,Remarks) VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9},'{10}',{11},'{12}')";
                query = string.Format(query, admitted_patient.GlobalPatientID, admitted_patient.PatientName, admitted_patient.AttendentName, admitted_patient.PatientCNIC, admitted_patient.AttendentPhone, admitted_patient.PatientAddress, admitted_patient.PatientDOB, admitted_patient.PatientGender, admitted_patient.AdmissionDate, admitted_patient.AdmittedByID, admitted_patient.DischargeDateTime, admitted_patient.DischargeAdminID, admitted_patient.Remarks);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM AdmittedPatient ORDER BY PatientID DESC";
                    ConnectAndExecute(query);

                    if (dt_admitted_patient.Rows.Count > 0)
                        patient_i_d = Convert.ToInt64(dt_admitted_patient.Rows[0]["PatientID"]);
                }
            }
            else
            {
                query = "UPDATE AdmittedPatient SET GlobalPatientID = {0}, PatientName = '{1}', AttendentName = '{2}', PatientCNIC = '{3}', AttendentPhone = '{4}', PatientAddress = '{5}', PatientDOB = '{6}', PatientGender = '{7}', AdmissionDate = '{8}', AdmittedByID = {9}, DischargeDateTime = '{10}', DischargeAdminID = {11}, Remarks = '{12}' WHERE PatientID = " + patient_i_d;
                query = string.Format(query, admitted_patient.GlobalPatientID, admitted_patient.PatientName, admitted_patient.AttendentName, admitted_patient.PatientCNIC, admitted_patient.AttendentPhone, admitted_patient.PatientAddress, admitted_patient.PatientDOB, admitted_patient.PatientGender, admitted_patient.AdmissionDate, admitted_patient.AdmittedByID, admitted_patient.DischargeDateTime, admitted_patient.DischargeAdminID, admitted_patient.Remarks);
                ConnectAndExecute(query);
                patient_i_d = admitted_patient.PatientID;
            }

            return patient_i_d;
        }

        public long DeleteAdmittedPatientByID(long patient_i_d)
        {
            string query = "DELETE AdmittedPatient WHERE PatientID = " + patient_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

