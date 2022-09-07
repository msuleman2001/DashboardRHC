using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class PatientSymptomModel
    {
        string connection_string;
        long patient_symptom_i_d = 0;
        int records_updated = 0;

        List<PatientSymptomEntity> patient_symptom_list = new List<PatientSymptomEntity>();
        PatientSymptomEntity patient_symptom = new PatientSymptomEntity();

        OleDbConnection con_patient_symptom;
        OleDbCommand com_patient_symptom;
        OleDbDataAdapter da_patient_symptom;
        DataTable dt_patient_symptom;

        public PatientSymptomModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_patient_symptom = new OleDbConnection(connection_string);
            com_patient_symptom = new OleDbCommand();
            da_patient_symptom = new OleDbDataAdapter();
            dt_patient_symptom = new DataTable();
        }

        private PatientSymptomEntity GetEntityTableMap(DataRow dr_patient_symptom)
        {
            PatientSymptomEntity patient_symptom = new PatientSymptomEntity();
            patient_symptom.PatientSymptomID = Convert.ToInt64(dr_patient_symptom["PatientSymptomID"]);
            patient_symptom.PatientID = Convert.ToInt64(dr_patient_symptom["PatientID"]);
            patient_symptom.SymptomID = Convert.ToInt64(dr_patient_symptom["SymptomID"]);
            patient_symptom.PatientSymptomValue = Convert.ToString(dr_patient_symptom["PatientSymptomValue"]);
            patient_symptom.DateCreated = Convert.ToDateTime(dr_patient_symptom["DateCreated"]);
            patient_symptom.CreatedByID = Convert.ToInt64(dr_patient_symptom["CreatedByID"]);
            patient_symptom.Remarks = Convert.ToString(dr_patient_symptom["Remarks"]);

            return patient_symptom;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_patient_symptom.State == ConnectionState.Open)
                    con_patient_symptom.Close();

                con_patient_symptom.Open();
                com_patient_symptom.CommandText = query;
                com_patient_symptom.Connection = con_patient_symptom;

                if (query.StartsWith("SELECT"))
                {
                    da_patient_symptom.SelectCommand = com_patient_symptom;
                    dt_patient_symptom.Clear();
                    da_patient_symptom.Fill(dt_patient_symptom);
                }
                else
                    records_updated = com_patient_symptom.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_patient_symptom = new DataTable();
                records_updated = 0;
            }
        }

        public List<PatientSymptomEntity> PatientSymptomSelectAll()
        {
            string query = "SELECT * FROM PatientSymptom";
            patient_symptom_list.Clear();
            ConnectAndExecute(query);
            if (dt_patient_symptom.Rows.Count > 0)
                foreach (DataRow dr_patient_symptom in dt_patient_symptom.Rows)
                {
                    patient_symptom = GetEntityTableMap(dr_patient_symptom);
                    patient_symptom_list.Add(patient_symptom);
                }

            return patient_symptom_list;
        }

        public PatientSymptomEntity SelectPatientSymptomByID(long patient_symptom_i_d)
        {
            patient_symptom = new PatientSymptomEntity();
            string query = "SELECT * FROM PatientSymptom WHERE PatientSymptomID = " + patient_symptom_i_d;
            ConnectAndExecute(query);

            if (dt_patient_symptom.Rows.Count > 0)
                patient_symptom = GetEntityTableMap(dt_patient_symptom.Rows[0]);

            return patient_symptom;
        }

        public long InsertUpdatePatientSymptom(PatientSymptomEntity patient_symptom)
        {
            string query = "";
            long patient_symptom_i_d = patient_symptom.PatientSymptomID;
            PatientSymptomEntity existed_patient_symptom = SelectPatientSymptomByID(patient_symptom_i_d);

            if (existed_patient_symptom.PatientSymptomID == 0)
            {
                query = "INSERT INTO PatientSymptom (PatientID,SymptomID,PatientSymptomValue,DateCreated,CreatedByID,Remarks) VALUES({0},{1},'{2}','{3}',{4},'{5}')";
                query = string.Format(query, patient_symptom.PatientID, patient_symptom.SymptomID, patient_symptom.PatientSymptomValue, patient_symptom.DateCreated, patient_symptom.CreatedByID, patient_symptom.Remarks);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM PatientSymptom ORDER BY PatientSymptomID DESC";
                    ConnectAndExecute(query);

                    if (dt_patient_symptom.Rows.Count > 0)
                        patient_symptom_i_d = Convert.ToInt64(dt_patient_symptom.Rows[0]["PatientSymptomID"]);
                }
            }
            else
            {
                query = "UPDATE PatientSymptom SET PatientID = {0}, SymptomID = {1}, PatientSymptomValue = '{2}', DateCreated = '{3}', CreatedByID = {4}, Remarks = '{5}' WHERE PatientSymptomID = " + patient_symptom_i_d;
                query = string.Format(query, patient_symptom.PatientID, patient_symptom.SymptomID, patient_symptom.PatientSymptomValue, patient_symptom.DateCreated, patient_symptom.CreatedByID, patient_symptom.Remarks);
                ConnectAndExecute(query);
                patient_symptom_i_d = patient_symptom.PatientSymptomID;
            }

            return patient_symptom_i_d;
        }

        public long DeletePatientSymptomByID(long patient_symptom_i_d)
        {
            string query = "DELETE PatientSymptom WHERE PatientSymptomID = " + patient_symptom_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

