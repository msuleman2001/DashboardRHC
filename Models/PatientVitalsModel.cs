using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class PatientVitalsModel
    {
        string connection_string;
        long patient_vital_i_d = 0;
        int records_updated = 0;

        List<PatientVitalsEntity> patient_vitals_list = new List<PatientVitalsEntity>();
        PatientVitalsEntity patient_vitals = new PatientVitalsEntity();

        OleDbConnection con_patient_vitals;
        OleDbCommand com_patient_vitals;
        OleDbDataAdapter da_patient_vitals;
        DataTable dt_patient_vitals;

        public PatientVitalsModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_patient_vitals = new OleDbConnection(connection_string);
            com_patient_vitals = new OleDbCommand();
            da_patient_vitals = new OleDbDataAdapter();
            dt_patient_vitals = new DataTable();
        }

        private PatientVitalsEntity GetEntityTableMap(DataRow dr_patient_vitals)
        {
            PatientVitalsEntity patient_vitals = new PatientVitalsEntity();
            patient_vitals.PatientVitalID = Convert.ToInt64(dr_patient_vitals["PatientVitalID"]);
            patient_vitals.PatientID = Convert.ToInt64(dr_patient_vitals["PatientID"]);
            patient_vitals.VitalName = Convert.ToString(dr_patient_vitals["VitalName"]);
            patient_vitals.VitalValue = Convert.ToString(dr_patient_vitals["VitalValue"]);
            patient_vitals.VitalDateTime = Convert.ToDateTime(dr_patient_vitals["VitalDateTime"]);

            return patient_vitals;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_patient_vitals.State == ConnectionState.Open)
                    con_patient_vitals.Close();

                con_patient_vitals.Open();
                com_patient_vitals.CommandText = query;
                com_patient_vitals.Connection = con_patient_vitals;

                if (query.StartsWith("SELECT"))
                {
                    da_patient_vitals.SelectCommand = com_patient_vitals;
                    dt_patient_vitals.Clear();
                    da_patient_vitals.Fill(dt_patient_vitals);
                }
                else
                    records_updated = com_patient_vitals.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_patient_vitals = new DataTable();
                records_updated = 0;
            }
        }

        public List<PatientVitalsEntity> PatientVitalsSelectAll()
        {
            string query = "SELECT * FROM PatientVitals";
            patient_vitals_list.Clear();
            ConnectAndExecute(query);
            if (dt_patient_vitals.Rows.Count > 0)
                foreach (DataRow dr_patient_vitals in dt_patient_vitals.Rows)
                {
                    patient_vitals = GetEntityTableMap(dr_patient_vitals);
                    patient_vitals_list.Add(patient_vitals);
                }

            return patient_vitals_list;
        }

        public PatientVitalsEntity SelectPatientVitalsByID(long patient_vital_i_d)
        {
            patient_vitals = new PatientVitalsEntity();
            string query = "SELECT * FROM PatientVitals WHERE PatientVitalID = " + patient_vital_i_d;
            ConnectAndExecute(query);

            if (dt_patient_vitals.Rows.Count > 0)
                patient_vitals = GetEntityTableMap(dt_patient_vitals.Rows[0]);

            return patient_vitals;
        }

        public long InsertUpdatePatientVitals(PatientVitalsEntity patient_vitals)
        {
            string query = "";
            long patient_vital_i_d = patient_vitals.PatientVitalID;
            PatientVitalsEntity existed_patient_vitals = SelectPatientVitalsByID(patient_vital_i_d);

            if (existed_patient_vitals.PatientVitalID == 0)
            {
                query = "INSERT INTO PatientVitals (PatientID,VitalName,VitalValue,VitalDateTime) VALUES({0},'{1}','{2}','{3}')";
                query = string.Format(query, patient_vitals.PatientID, patient_vitals.VitalName, patient_vitals.VitalValue, patient_vitals.VitalDateTime);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM PatientVitals ORDER BY PatientVitalID DESC";
                    ConnectAndExecute(query);

                    if (dt_patient_vitals.Rows.Count > 0)
                        patient_vital_i_d = Convert.ToInt64(dt_patient_vitals.Rows[0]["PatientVitalID"]);
                }
            }
            else
            {
                query = "UPDATE PatientVitals SET PatientID = {0}, VitalName = '{1}', VitalValue = '{2}', VitalDateTime = '{3}' WHERE PatientVitalID = " + patient_vital_i_d;
                query = string.Format(query, patient_vitals.PatientID, patient_vitals.VitalName, patient_vitals.VitalValue, patient_vitals.VitalDateTime);
                ConnectAndExecute(query);
                patient_vital_i_d = patient_vitals.PatientVitalID;
            }

            return patient_vital_i_d;
        }

        public long DeletePatientVitalsByID(long patient_vital_i_d)
        {
            string query = "DELETE PatientVitals WHERE PatientVitalID = " + patient_vital_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}
