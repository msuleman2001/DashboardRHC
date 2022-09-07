using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class LabTestModel
    {
        string connection_string;
        long lab_test_i_d = 0;
        int records_updated = 0;

        List<LabTestEntity> lab_test_list = new List<LabTestEntity>();
        LabTestEntity lab_test = new LabTestEntity();

        OleDbConnection con_lab_test;
        OleDbCommand com_lab_test;
        OleDbDataAdapter da_lab_test;
        DataTable dt_lab_test;

        public LabTestModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_lab_test = new OleDbConnection(connection_string);
            com_lab_test = new OleDbCommand();
            da_lab_test = new OleDbDataAdapter();
            dt_lab_test = new DataTable();
        }

        private LabTestEntity GetEntityTableMap(DataRow dr_lab_test)
        {
            LabTestEntity lab_test = new LabTestEntity();
            lab_test.LabTestID = Convert.ToInt64(dr_lab_test["LabTestID"]);
            lab_test.LabTestName = Convert.ToString(dr_lab_test["LabTestName"]);
            lab_test.NormalRange = Convert.ToString(dr_lab_test["NormalRange"]);
            lab_test.Remarks = Convert.ToString(dr_lab_test["Remarks"]);
            lab_test.CreatedByID = Convert.ToInt64(dr_lab_test["CreatedByID"]);
            lab_test.CreatedDateTime = Convert.ToDateTime(dr_lab_test["CreatedDateTime"]);

            return lab_test;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_lab_test.State == ConnectionState.Open)
                    con_lab_test.Close();

                con_lab_test.Open();
                com_lab_test.CommandText = query;
                com_lab_test.Connection = con_lab_test;

                if (query.StartsWith("SELECT"))
                {
                    da_lab_test.SelectCommand = com_lab_test;
                    dt_lab_test.Clear();
                    da_lab_test.Fill(dt_lab_test);
                }
                else
                    records_updated = com_lab_test.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_lab_test = new DataTable();
                records_updated = 0;
            }
        }

        public List<LabTestEntity> LabTestSelectAll()
        {
            string query = "SELECT * FROM LabTest";
            lab_test_list.Clear();
            ConnectAndExecute(query);
            if (dt_lab_test.Rows.Count > 0)
                foreach (DataRow dr_lab_test in dt_lab_test.Rows)
                {
                    lab_test = GetEntityTableMap(dr_lab_test);
                    lab_test_list.Add(lab_test);
                }

            return lab_test_list;
        }

        public LabTestEntity SelectLabTestByID(long lab_test_i_d)
        {
            lab_test = new LabTestEntity();
            string query = "SELECT * FROM LabTest WHERE LabTestID = " + lab_test_i_d;
            ConnectAndExecute(query);

            if (dt_lab_test.Rows.Count > 0)
                lab_test = GetEntityTableMap(dt_lab_test.Rows[0]);

            return lab_test;
        }

        public long InsertUpdateLabTest(LabTestEntity lab_test)
        {
            string query = "";
            long lab_test_i_d = lab_test.LabTestID;
            LabTestEntity existed_lab_test = SelectLabTestByID(lab_test_i_d);

            if (existed_lab_test.LabTestID == 0)
            {
                query = "INSERT INTO LabTest (LabTestName,NormalRange,Remarks,CreatedByID,CreatedDateTime) VALUES('{0}','{1}','{2}',{3},'{4}')";
                query = string.Format(query, lab_test.LabTestName, lab_test.NormalRange, lab_test.Remarks, lab_test.CreatedByID, lab_test.CreatedDateTime);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM LabTest ORDER BY LabTestID DESC";
                    ConnectAndExecute(query);

                    if (dt_lab_test.Rows.Count > 0)
                        lab_test_i_d = Convert.ToInt64(dt_lab_test.Rows[0]["LabTestID"]);
                }
            }
            else
            {
                query = "UPDATE LabTest SET LabTestName = '{0}', NormalRange = '{1}', Remarks = '{2}', CreatedByID = {3}, CreatedDateTime = '{4}' WHERE LabTestID = " + lab_test_i_d;
                query = string.Format(query, lab_test.LabTestName, lab_test.NormalRange, lab_test.Remarks, lab_test.CreatedByID, lab_test.CreatedDateTime);
                ConnectAndExecute(query);
                lab_test_i_d = lab_test.LabTestID;
            }

            return lab_test_i_d;
        }

        public long DeleteLabTestByID(long lab_test_i_d)
        {
            string query = "DELETE LabTest WHERE LabTestID = " + lab_test_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}
