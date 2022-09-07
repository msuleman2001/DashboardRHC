using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class CenterAdminModel
    {
        string connection_string;
        long admin_i_d = 0;
        int records_updated = 0;

        List<CenterAdminEntity> center_admin_list = new List<CenterAdminEntity>();
        CenterAdminEntity center_admin = new CenterAdminEntity();

        OleDbConnection con_center_admin;
        OleDbCommand com_center_admin;
        OleDbDataAdapter da_center_admin;
        DataTable dt_center_admin;

        public CenterAdminModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_center_admin = new OleDbConnection(connection_string);
            com_center_admin = new OleDbCommand();
            da_center_admin = new OleDbDataAdapter();
            dt_center_admin = new DataTable();
        }

        private CenterAdminEntity GetEntityTableMap(DataRow dr_center_admin)
        {
            CenterAdminEntity center_admin = new CenterAdminEntity();
            center_admin.AdminID = Convert.ToInt64(dr_center_admin["AdminID"]);
            center_admin.AdminName = Convert.ToString(dr_center_admin["AdminName"]);
            center_admin.AdminPassword = Convert.ToString(dr_center_admin["AdminPassword"]);
            center_admin.AdminImage = Convert.ToString(dr_center_admin["AdminImage"]);
            center_admin.CreatedByID = Convert.ToInt64(dr_center_admin["CreatedByID"]);
            center_admin.CreatedDateTime = Convert.ToDateTime(dr_center_admin["CreatedDateTime"]);
            center_admin.IsEnabled = Convert.ToString(dr_center_admin["IsEnabled"]);
            center_admin.Remarks = Convert.ToString(dr_center_admin["Remarks"]);

            return center_admin;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_center_admin.State == ConnectionState.Open)
                    con_center_admin.Close();

                con_center_admin.Open();
                com_center_admin.CommandText = query;
                com_center_admin.Connection = con_center_admin;

                if (query.StartsWith("SELECT"))
                {
                    da_center_admin.SelectCommand = com_center_admin;
                    dt_center_admin.Clear();
                    da_center_admin.Fill(dt_center_admin);
                }
                else
                    records_updated = com_center_admin.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_center_admin = new DataTable();
                records_updated = 0;
            }
        }

        public List<CenterAdminEntity> CenterAdminSelectAll()
        {
            string query = "SELECT * FROM CenterAdmin";
            center_admin_list.Clear();
            ConnectAndExecute(query);
            if (dt_center_admin.Rows.Count > 0)
                foreach (DataRow dr_center_admin in dt_center_admin.Rows)
                {
                    center_admin = GetEntityTableMap(dr_center_admin);
                    center_admin_list.Add(center_admin);
                }

            return center_admin_list;
        }

        public CenterAdminEntity SelectCenterAdminByID(long admin_i_d)
        {
            center_admin = new CenterAdminEntity();
            string query = "SELECT * FROM CenterAdmin WHERE AdminID = " + admin_i_d;
            ConnectAndExecute(query);

            if (dt_center_admin.Rows.Count > 0)
                center_admin = GetEntityTableMap(dt_center_admin.Rows[0]);

            return center_admin;
        }

        public long InsertUpdateCenterAdmin(CenterAdminEntity center_admin)
        {
            string query = "";
            long admin_i_d = center_admin.AdminID;
            CenterAdminEntity existed_center_admin = SelectCenterAdminByID(admin_i_d);

            if (existed_center_admin.AdminID == 0)
            {
                query = "INSERT INTO CenterAdmin (AdminName,AdminPassword,AdminImage,CreatedByID,CreatedDateTime,IsEnabled,Remarks) VALUES('{0}','{1}','{2}',{3},'{4}','{5}','{6}')";
                query = string.Format(query, center_admin.AdminName, center_admin.AdminPassword, center_admin.AdminImage, center_admin.CreatedByID, center_admin.CreatedDateTime, center_admin.IsEnabled, center_admin.Remarks);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM CenterAdmin ORDER BY AdminID DESC";
                    ConnectAndExecute(query);

                    if (dt_center_admin.Rows.Count > 0)
                        admin_i_d = Convert.ToInt64(dt_center_admin.Rows[0]["AdminID"]);
                }
            }
            else
            {
                query = "UPDATE CenterAdmin SET AdminName = '{0}', AdminPassword = '{1}', AdminImage = '{2}', CreatedByID = {3}, CreatedDateTime = '{4}', IsEnabled = '{5}', Remarks = '{6}' WHERE AdminID = " + admin_i_d;
                query = string.Format(query, center_admin.AdminName, center_admin.AdminPassword, center_admin.AdminImage, center_admin.CreatedByID, center_admin.CreatedDateTime, center_admin.IsEnabled, center_admin.Remarks);
                ConnectAndExecute(query);
                admin_i_d = center_admin.AdminID;
            }

            return admin_i_d;
        }

        public long DeleteCenterAdminByID(long admin_i_d)
        {
            string query = "DELETE CenterAdmin WHERE AdminID = " + admin_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

