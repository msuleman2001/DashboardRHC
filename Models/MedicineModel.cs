using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class MedicineModel
    {
        string connection_string;
        long medicine_i_d = 0;
        int records_updated = 0;

        List<MedicineEntity> medicine_list = new List<MedicineEntity>();
        MedicineEntity medicine = new MedicineEntity();

        OleDbConnection con_medicine;
        OleDbCommand com_medicine;
        OleDbDataAdapter da_medicine;
        DataTable dt_medicine;

        public MedicineModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_medicine = new OleDbConnection(connection_string);
            com_medicine = new OleDbCommand();
            da_medicine = new OleDbDataAdapter();
            dt_medicine = new DataTable();
        }

        private MedicineEntity GetEntityTableMap(DataRow dr_medicine)
        {
            MedicineEntity medicine = new MedicineEntity();
            medicine.MedicineID = Convert.ToInt64(dr_medicine["MedicineID"]);
            medicine.MedicineName = Convert.ToString(dr_medicine["MedicineName"]);
            medicine.Potency = Convert.ToString(dr_medicine["Potency"]);
            medicine.Remarks = Convert.ToString(dr_medicine["Remarks"]);
            medicine.CreatedByID = Convert.ToInt64(dr_medicine["CreatedByID"]);
            medicine.CreatedDateTime = Convert.ToDateTime(dr_medicine["CreatedDateTime"]);

            return medicine;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_medicine.State == ConnectionState.Open)
                    con_medicine.Close();

                con_medicine.Open();
                com_medicine.CommandText = query;
                com_medicine.Connection = con_medicine;

                if (query.StartsWith("SELECT"))
                {
                    da_medicine.SelectCommand = com_medicine;
                    dt_medicine.Clear();
                    da_medicine.Fill(dt_medicine);
                }
                else
                    records_updated = com_medicine.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_medicine = new DataTable();
                records_updated = 0;
            }
        }

        public List<MedicineEntity> MedicineSelectAll()
        {
            string query = "SELECT * FROM Medicine";
            medicine_list.Clear();
            ConnectAndExecute(query);
            if (dt_medicine.Rows.Count > 0)
                foreach (DataRow dr_medicine in dt_medicine.Rows)
                {
                    medicine = GetEntityTableMap(dr_medicine);
                    medicine_list.Add(medicine);
                }

            return medicine_list;
        }

        public MedicineEntity SelectMedicineByID(long medicine_i_d)
        {
            medicine = new MedicineEntity();
            string query = "SELECT * FROM Medicine WHERE MedicineID = " + medicine_i_d;
            ConnectAndExecute(query);

            if (dt_medicine.Rows.Count > 0)
                medicine = GetEntityTableMap(dt_medicine.Rows[0]);

            return medicine;
        }

        public long InsertUpdateMedicine(MedicineEntity medicine)
        {
            string query = "";
            long medicine_i_d = medicine.MedicineID;
            MedicineEntity existed_medicine = SelectMedicineByID(medicine_i_d);

            if (existed_medicine.MedicineID == 0)
            {
                query = "INSERT INTO Medicine (MedicineName,Potency,Remarks,CreatedByID,CreatedDateTime) VALUES('{0}','{1}','{2}',{3},'{4}')";
                query = string.Format(query, medicine.MedicineName, medicine.Potency, medicine.Remarks, medicine.CreatedByID, medicine.CreatedDateTime);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM Medicine ORDER BY MedicineID DESC";
                    ConnectAndExecute(query);

                    if (dt_medicine.Rows.Count > 0)
                        medicine_i_d = Convert.ToInt64(dt_medicine.Rows[0]["MedicineID"]);
                }
            }
            else
            {
                query = "UPDATE Medicine SET MedicineName = '{0}', Potency = '{1}', Remarks = '{2}', CreatedByID = {3}, CreatedDateTime = '{4}' WHERE MedicineID = " + medicine_i_d;
                query = string.Format(query, medicine.MedicineName, medicine.Potency, medicine.Remarks, medicine.CreatedByID, medicine.CreatedDateTime);
                ConnectAndExecute(query);
                medicine_i_d = medicine.MedicineID;
            }

            return medicine_i_d;
        }

        public long DeleteMedicineByID(long medicine_i_d)
        {
            string query = "DELETE Medicine WHERE MedicineID = " + medicine_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

