using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    //this updated by asad
    public class AdminLogModel
    {
        string connection_string;
        long admin_log_i_d = 0;
        int records_updated = 0;

        List<AdminLogEntity> admin_log_list = new List<AdminLogEntity>();
        AdminLogEntity admin_log = new AdminLogEntity();

        OleDbConnection con_admin_log;
        OleDbCommand com_admin_log;
        OleDbDataAdapter da_admin_log;
        DataTable dt_admin_log;

        public AdminLogModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_admin_log = new OleDbConnection(connection_string);
            com_admin_log = new OleDbCommand();
            da_admin_log = new OleDbDataAdapter();
            dt_admin_log = new DataTable();
        }

        private AdminLogEntity GetEntityTableMap(DataRow dr_admin_log)
        {
            AdminLogEntity admin_log = new AdminLogEntity();
            admin_log.AdminLogID = Convert.ToInt64(dr_admin_log["AdminLogID"]);
            admin_log.AdminID = Convert.ToInt64(dr_admin_log["AdminID"]);
            admin_log.LoginDateTime = Convert.ToDateTime(dr_admin_log["LoginDateTime"]);
            admin_log.LogoutDateTime = Convert.ToDateTime(dr_admin_log["LogoutDateTime"]);
            admin_log.Remarks = Convert.ToString(dr_admin_log["Remarks"]);

            return admin_log;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_admin_log.State == ConnectionState.Open)
                    con_admin_log.Close();

                con_admin_log.Open();
                com_admin_log.CommandText = query;
                com_admin_log.Connection = con_admin_log;

                if (query.StartsWith("SELECT"))
                {
                    da_admin_log.SelectCommand = com_admin_log;
                    dt_admin_log.Clear();
                    da_admin_log.Fill(dt_admin_log);
                }
                else
                    records_updated = com_admin_log.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_admin_log = new DataTable();
                records_updated = 0;
            }
        }

        public List<AdminLogEntity> AdminLogSelectAll()
        {
            string query = "SELECT * FROM AdminLog";
            admin_log_list.Clear();
            ConnectAndExecute(query);
            if (dt_admin_log.Rows.Count > 0)
                foreach (DataRow dr_admin_log in dt_admin_log.Rows)
                {
                    admin_log = GetEntityTableMap(dr_admin_log);
                    admin_log_list.Add(admin_log);
                }

            return admin_log_list;
        }

        public AdminLogEntity SelectAdminLogByID(long admin_log_i_d)
        {
            admin_log = new AdminLogEntity();
            string query = "SELECT * FROM AdminLog WHERE AdminLogID = " + admin_log_i_d;
            ConnectAndExecute(query);

            if (dt_admin_log.Rows.Count > 0)
                admin_log = GetEntityTableMap(dt_admin_log.Rows[0]);

            return admin_log;
        }

        public long InsertUpdateAdminLog(AdminLogEntity admin_log)
        {
            string query = "";
            long admin_log_i_d = admin_log.AdminLogID;
            AdminLogEntity existed_admin_log = SelectAdminLogByID(admin_log_i_d);

            if (existed_admin_log.AdminLogID == 0)
            {
                query = "INSERT INTO AdminLog (AdminID,LoginDateTime,LogoutDateTime,Remarks) VALUES({0},'{1}','{2}','{3}')";
                query = string.Format(query, admin_log.AdminID, admin_log.LoginDateTime, admin_log.LogoutDateTime, admin_log.Remarks);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM AdminLog ORDER BY AdminLogID DESC";
                    ConnectAndExecute(query);

                    if (dt_admin_log.Rows.Count > 0)
                        admin_log_i_d = Convert.ToInt64(dt_admin_log.Rows[0]["AdminLogID"]);
                }
            }
            else
            {
                query = "UPDATE AdminLog SET AdminID = {0}, LoginDateTime = '{1}', LogoutDateTime = '{2}', Remarks = '{3}' WHERE AdminLogID = " + admin_log_i_d;
                query = string.Format(query, admin_log.AdminID, admin_log.LoginDateTime, admin_log.LogoutDateTime, admin_log.Remarks);
                ConnectAndExecute(query);
                admin_log_i_d = admin_log.AdminLogID;
            }

            return admin_log_i_d;
        }

        public long DeleteAdminLogByID(long admin_log_i_d)
        {
            string query = "DELETE AdminLog WHERE AdminLogID = " + admin_log_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

