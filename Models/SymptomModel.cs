using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class SymptomModel
    {
        string connection_string;
        long symptom_i_d = 0;
        int records_updated = 0;

        List<SymptomEntity> symptom_list = new List<SymptomEntity>();
        SymptomEntity symptom = new SymptomEntity();

        OleDbConnection con_symptom;
        OleDbCommand com_symptom;
        OleDbDataAdapter da_symptom;
        DataTable dt_symptom;

        public SymptomModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_symptom = new OleDbConnection(connection_string);
            com_symptom = new OleDbCommand();
            da_symptom = new OleDbDataAdapter();
            dt_symptom = new DataTable();
        }

        private SymptomEntity GetEntityTableMap(DataRow dr_symptom)
        {
            SymptomEntity symptom = new SymptomEntity();
            symptom.SymptomID = Convert.ToInt64(dr_symptom["SymptomID"]);
            symptom.SymptomTitle = Convert.ToString(dr_symptom["SymptomTitle"]);
            symptom.CategoryAndValue = Convert.ToString(dr_symptom["CategoryAndValue"]);
            symptom.CreatedDateTime = Convert.ToDateTime(dr_symptom["CreatedDateTime"]);
            symptom.SymptomRemarks = Convert.ToString(dr_symptom["SymptomRemarks"]);
            symptom.SymptomEnabled = Convert.ToString(dr_symptom["SymptomEnabled"]);
            symptom.CreatedByID = Convert.ToInt64(dr_symptom["CreatedByID"]);

            return symptom;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_symptom.State == ConnectionState.Open)
                    con_symptom.Close();

                con_symptom.Open();
                com_symptom.CommandText = query;
                com_symptom.Connection = con_symptom;

                if (query.StartsWith("SELECT"))
                {
                    da_symptom.SelectCommand = com_symptom;
                    dt_symptom.Clear();
                    da_symptom.Fill(dt_symptom);
                }
                else
                    records_updated = com_symptom.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_symptom = new DataTable();
                records_updated = 0;
            }
        }

        public List<SymptomEntity> SymptomSelectAll()
        {
            string query = "SELECT * FROM Symptom";
            symptom_list.Clear();
            ConnectAndExecute(query);
            if (dt_symptom.Rows.Count > 0)
                foreach (DataRow dr_symptom in dt_symptom.Rows)
                {
                    symptom = GetEntityTableMap(dr_symptom);
                    symptom_list.Add(symptom);
                }

            return symptom_list;
        }

        public SymptomEntity SelectSymptomByID(long symptom_i_d)
        {
            symptom = new SymptomEntity();
            string query = "SELECT * FROM Symptom WHERE SymptomID = " + symptom_i_d;
            ConnectAndExecute(query);

            if (dt_symptom.Rows.Count > 0)
                symptom = GetEntityTableMap(dt_symptom.Rows[0]);

            return symptom;
        }

        public long InsertUpdateSymptom(SymptomEntity symptom)
        {
            string query = "";
            long symptom_i_d = symptom.SymptomID;
            SymptomEntity existed_symptom = SelectSymptomByID(symptom_i_d);

            if (existed_symptom.SymptomID == 0)
            {
                query = "INSERT INTO Symptom (SymptomTitle,CategoryAndValue,CreatedDateTime,SymptomRemarks,SymptomEnabled,CreatedByID) VALUES('{0}','{1}','{2}','{3}','{4}',{5})";
                query = string.Format(query, symptom.SymptomTitle, symptom.CategoryAndValue, symptom.CreatedDateTime, symptom.SymptomRemarks, symptom.SymptomEnabled, symptom.CreatedByID);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM Symptom ORDER BY SymptomID DESC";
                    ConnectAndExecute(query);

                    if (dt_symptom.Rows.Count > 0)
                        symptom_i_d = Convert.ToInt64(dt_symptom.Rows[0]["SymptomID"]);
                }
            }
            else
            {
                query = "UPDATE Symptom SET SymptomTitle = '{0}', CategoryAndValue = '{1}', CreatedDateTime = '{2}', SymptomRemarks = '{3}', SymptomEnabled = '{4}', CreatedByID = {5} WHERE SymptomID = " + symptom_i_d;
                query = string.Format(query, symptom.SymptomTitle, symptom.CategoryAndValue, symptom.CreatedDateTime, symptom.SymptomRemarks, symptom.SymptomEnabled, symptom.CreatedByID);
                ConnectAndExecute(query);
                symptom_i_d = symptom.SymptomID;
            }

            return symptom_i_d;
        }

        public long DeleteSymptomByID(long symptom_i_d)
        {
            string query = "DELETE Symptom WHERE SymptomID = " + symptom_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

