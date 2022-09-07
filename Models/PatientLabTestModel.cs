using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class PatientLabTestModel
    {
        string connection_string;
        long patient_lab_test_i_d = 0;
        int records_updated = 0;

        List<PatientLabTestEntity> patient_lab_test_list = new List<PatientLabTestEntity>();
        PatientLabTestEntity patient_lab_test = new PatientLabTestEntity();

        OleDbConnection con_patient_lab_test;
        OleDbCommand com_patient_lab_test;
        OleDbDataAdapter da_patient_lab_test;
        DataTable dt_patient_lab_test;

        public PatientLabTestModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_patient_lab_test = new OleDbConnection(connection_string);
            com_patient_lab_test = new OleDbCommand();
            da_patient_lab_test = new OleDbDataAdapter();
            dt_patient_lab_test = new DataTable();
        }

        private PatientLabTestEntity GetEntityTableMap(DataRow dr_patient_lab_test)
        {
            PatientLabTestEntity patient_lab_test = new PatientLabTestEntity();
            patient_lab_test.PatientLabTestID = Convert.ToInt64(dr_patient_lab_test["PatientLabTestID"]);
            patient_lab_test.LabTestID = Convert.ToInt64(dr_patient_lab_test["LabTestID"]);
            patient_lab_test.PatientID = Convert.ToInt64(dr_patient_lab_test["PatientID"]);
            patient_lab_test.LabTestValue = Convert.ToString(dr_patient_lab_test["LabTestValue"]);
            patient_lab_test.Remarks = Convert.ToString(dr_patient_lab_test["Remarks"]);
            patient_lab_test.CreatedByID = Convert.ToInt64(dr_patient_lab_test["CreatedByID"]);
            patient_lab_test.CreatedDateTime = Convert.ToDateTime(dr_patient_lab_test["CreatedDateTime"]);

            return patient_lab_test;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_patient_lab_test.State == ConnectionState.Open)
                    con_patient_lab_test.Close();

                con_patient_lab_test.Open();
                com_patient_lab_test.CommandText = query;
                com_patient_lab_test.Connection = con_patient_lab_test;

                if (query.StartsWith("SELECT"))
                {
                    da_patient_lab_test.SelectCommand = com_patient_lab_test;
                    dt_patient_lab_test.Clear();
                    da_patient_lab_test.Fill(dt_patient_lab_test);
                }
                else
                    records_updated = com_patient_lab_test.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_patient_lab_test = new DataTable();
                records_updated = 0;
            }
        }

        public List<PatientLabTestEntity> PatientLabTestSelectAll()
        {
            string query = "SELECT * FROM PatientLabTest";
            patient_lab_test_list.Clear();
            ConnectAndExecute(query);
            if (dt_patient_lab_test.Rows.Count > 0)
                foreach (DataRow dr_patient_lab_test in dt_patient_lab_test.Rows)
                {
                    patient_lab_test = GetEntityTableMap(dr_patient_lab_test);
                    patient_lab_test_list.Add(patient_lab_test);
                }

            return patient_lab_test_list;
        }

        public PatientLabTestEntity SelectPatientLabTestByID(long patient_lab_test_i_d)
        {
            patient_lab_test = new PatientLabTestEntity();
            string query = "SELECT * FROM PatientLabTest WHERE PatientLabTestID = " + patient_lab_test_i_d;
            ConnectAndExecute(query);

            if (dt_patient_lab_test.Rows.Count > 0)
                patient_lab_test = GetEntityTableMap(dt_patient_lab_test.Rows[0]);

            return patient_lab_test;
        }

        public long InsertUpdatePatientLabTest(PatientLabTestEntity patient_lab_test)
        {
            string query = "";
            long patient_lab_test_i_d = patient_lab_test.PatientLabTestID;
            PatientLabTestEntity existed_patient_lab_test = SelectPatientLabTestByID(patient_lab_test_i_d);

            if (existed_patient_lab_test.PatientLabTestID == 0)
            {
                query = "INSERT INTO PatientLabTest (LabTestID,PatientID,LabTestValue,Remarks,CreatedByID,CreatedDateTime) VALUES({0},{1},'{2}','{3}',{4},'{5}')";
                query = string.Format(query, patient_lab_test.LabTestID, patient_lab_test.PatientID, patient_lab_test.LabTestValue, patient_lab_test.Remarks, patient_lab_test.CreatedByID, patient_lab_test.CreatedDateTime);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM PatientLabTest ORDER BY PatientLabTestID DESC";
                    ConnectAndExecute(query);

                    if (dt_patient_lab_test.Rows.Count > 0)
                        patient_lab_test_i_d = Convert.ToInt64(dt_patient_lab_test.Rows[0]["PatientLabTestID"]);
                }
            }
            else
            {
                query = "UPDATE PatientLabTest SET LabTestID = {0}, PatientID = {1}, LabTestValue = '{2}', Remarks = '{3}', CreatedByID = {4}, CreatedDateTime = '{5}' WHERE PatientLabTestID = " + patient_lab_test_i_d;
                query = string.Format(query, patient_lab_test.LabTestID, patient_lab_test.PatientID, patient_lab_test.LabTestValue, patient_lab_test.Remarks, patient_lab_test.CreatedByID, patient_lab_test.CreatedDateTime);
                ConnectAndExecute(query);
                patient_lab_test_i_d = patient_lab_test.PatientLabTestID;
            }

            return patient_lab_test_i_d;
        }

        public long DeletePatientLabTestByID(long patient_lab_test_i_d)
        {
            string query = "DELETE PatientLabTest WHERE PatientLabTestID = " + patient_lab_test_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

