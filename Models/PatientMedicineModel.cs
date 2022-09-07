using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class PatientMedicineModel
    {
        string connection_string;
        long patient_medicine_i_d = 0;
        int records_updated = 0;

        List<PatientMedicineEntity> patient_medicine_list = new List<PatientMedicineEntity>();
        PatientMedicineEntity patient_medicine = new PatientMedicineEntity();

        OleDbConnection con_patient_medicine;
        OleDbCommand com_patient_medicine;
        OleDbDataAdapter da_patient_medicine;
        DataTable dt_patient_medicine;

        public PatientMedicineModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_patient_medicine = new OleDbConnection(connection_string);
            com_patient_medicine = new OleDbCommand();
            da_patient_medicine = new OleDbDataAdapter();
            dt_patient_medicine = new DataTable();
        }

        private PatientMedicineEntity GetEntityTableMap(DataRow dr_patient_medicine)
        {
            PatientMedicineEntity patient_medicine = new PatientMedicineEntity();
            patient_medicine.PatientMedicineID = Convert.ToInt64(dr_patient_medicine["PatientMedicineID"]);
            patient_medicine.PatientID = Convert.ToInt64(dr_patient_medicine["PatientID"]);
            patient_medicine.MedicineID = Convert.ToInt64(dr_patient_medicine["MedicineID"]);
            patient_medicine.Dosage = Convert.ToString(dr_patient_medicine["Dosage"]);
            patient_medicine.CreatedByID = Convert.ToInt64(dr_patient_medicine["CreatedByID"]);
            patient_medicine.CreatedDateTime = Convert.ToDateTime(dr_patient_medicine["CreatedDateTime"]);
            patient_medicine.Remarks = Convert.ToString(dr_patient_medicine["Remarks"]);

            return patient_medicine;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_patient_medicine.State == ConnectionState.Open)
                    con_patient_medicine.Close();

                con_patient_medicine.Open();
                com_patient_medicine.CommandText = query;
                com_patient_medicine.Connection = con_patient_medicine;

                if (query.StartsWith("SELECT"))
                {
                    da_patient_medicine.SelectCommand = com_patient_medicine;
                    dt_patient_medicine.Clear();
                    da_patient_medicine.Fill(dt_patient_medicine);
                }
                else
                    records_updated = com_patient_medicine.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_patient_medicine = new DataTable();
                records_updated = 0;
            }
        }

        public List<PatientMedicineEntity> PatientMedicineSelectAll()
        {
            string query = "SELECT * FROM PatientMedicine";
            patient_medicine_list.Clear();
            ConnectAndExecute(query);
            if (dt_patient_medicine.Rows.Count > 0)
                foreach (DataRow dr_patient_medicine in dt_patient_medicine.Rows)
                {
                    patient_medicine = GetEntityTableMap(dr_patient_medicine);
                    patient_medicine_list.Add(patient_medicine);
                }

            return patient_medicine_list;
        }

        public PatientMedicineEntity SelectPatientMedicineByID(long patient_medicine_i_d)
        {
            patient_medicine = new PatientMedicineEntity();
            string query = "SELECT * FROM PatientMedicine WHERE PatientMedicineID = " + patient_medicine_i_d;
            ConnectAndExecute(query);

            if (dt_patient_medicine.Rows.Count > 0)
                patient_medicine = GetEntityTableMap(dt_patient_medicine.Rows[0]);

            return patient_medicine;
        }

        public long InsertUpdatePatientMedicine(PatientMedicineEntity patient_medicine)
        {
            string query = "";
            long patient_medicine_i_d = patient_medicine.PatientMedicineID;
            PatientMedicineEntity existed_patient_medicine = SelectPatientMedicineByID(patient_medicine_i_d);

            if (existed_patient_medicine.PatientMedicineID == 0)
            {
                query = "INSERT INTO PatientMedicine (PatientID,MedicineID,Dosage,CreatedByID,CreatedDateTime,Remarks) VALUES({0},{1},'{2}',{3},'{4}','{5}')";
                query = string.Format(query, patient_medicine.PatientID, patient_medicine.MedicineID, patient_medicine.Dosage, patient_medicine.CreatedByID, patient_medicine.CreatedDateTime, patient_medicine.Remarks);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM PatientMedicine ORDER BY PatientMedicineID DESC";
                    ConnectAndExecute(query);

                    if (dt_patient_medicine.Rows.Count > 0)
                        patient_medicine_i_d = Convert.ToInt64(dt_patient_medicine.Rows[0]["PatientMedicineID"]);
                }
            }
            else
            {
                query = "UPDATE PatientMedicine SET PatientID = {0}, MedicineID = {1}, Dosage = '{2}', CreatedByID = {3}, CreatedDateTime = '{4}', Remarks = '{5}' WHERE PatientMedicineID = " + patient_medicine_i_d;
                query = string.Format(query, patient_medicine.PatientID, patient_medicine.MedicineID, patient_medicine.Dosage, patient_medicine.CreatedByID, patient_medicine.CreatedDateTime, patient_medicine.Remarks);
                ConnectAndExecute(query);
                patient_medicine_i_d = patient_medicine.PatientMedicineID;
            }

            return patient_medicine_i_d;
        }

        public long DeletePatientMedicineByID(long patient_medicine_i_d)
        {
            string query = "DELETE PatientMedicine WHERE PatientMedicineID = " + patient_medicine_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

