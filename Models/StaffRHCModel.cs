using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class StaffRHCModel
    {
        string connection_string;
        long staff_i_d = 0;
        int records_updated = 0;

        List<StaffRHCEntity> staff_r_h_c_list = new List<StaffRHCEntity>();
        StaffRHCEntity staff_r_h_c = new StaffRHCEntity();

        OleDbConnection con_staff_r_h_c;
        OleDbCommand com_staff_r_h_c;
        OleDbDataAdapter da_staff_r_h_c;
        DataTable dt_staff_r_h_c;

        public StaffRHCModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_staff_r_h_c = new OleDbConnection(connection_string);
            com_staff_r_h_c = new OleDbCommand();
            da_staff_r_h_c = new OleDbDataAdapter();
            dt_staff_r_h_c = new DataTable();
        }

        private StaffRHCEntity GetEntityTableMap(DataRow dr_staff_r_h_c)
        {
            StaffRHCEntity staff_r_h_c = new StaffRHCEntity();
            staff_r_h_c.StaffID = Convert.ToInt64(dr_staff_r_h_c["StaffID"]);
            staff_r_h_c.StaffName = Convert.ToString(dr_staff_r_h_c["StaffName"]);
            staff_r_h_c.StaffPassword = Convert.ToString(dr_staff_r_h_c["StaffPassword"]);
            staff_r_h_c.StaffPhone = Convert.ToString(dr_staff_r_h_c["StaffPhone"]);
            staff_r_h_c.StaffAddress = Convert.ToString(dr_staff_r_h_c["StaffAddress"]);
            staff_r_h_c.Designation = Convert.ToString(dr_staff_r_h_c["Designation"]);
            staff_r_h_c.Qualification = Convert.ToString(dr_staff_r_h_c["Qualification"]);
            staff_r_h_c.CreatedByID = Convert.ToInt64(dr_staff_r_h_c["CreatedByID"]);
            staff_r_h_c.CreatedDateTime = Convert.ToDateTime(dr_staff_r_h_c["CreatedDateTime"]);
            staff_r_h_c.IsEnabled = Convert.ToString(dr_staff_r_h_c["IsEnabled"]);
            staff_r_h_c.LastUpdateDateTime = Convert.ToDateTime(dr_staff_r_h_c["LastUpdateDateTime"]);
            staff_r_h_c.LastUpdateID = Convert.ToInt64(dr_staff_r_h_c["LastUpdateID"]);
            staff_r_h_c.Remarks = Convert.ToString(dr_staff_r_h_c["Remarks"]);

            return staff_r_h_c;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_staff_r_h_c.State == ConnectionState.Open)
                    con_staff_r_h_c.Close();

                con_staff_r_h_c.Open();
                com_staff_r_h_c.CommandText = query;
                com_staff_r_h_c.Connection = con_staff_r_h_c;

                if (query.StartsWith("SELECT"))
                {
                    da_staff_r_h_c.SelectCommand = com_staff_r_h_c;
                    dt_staff_r_h_c.Clear();
                    da_staff_r_h_c.Fill(dt_staff_r_h_c);
                }
                else
                    records_updated = com_staff_r_h_c.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_staff_r_h_c = new DataTable();
                records_updated = 0;
            }
        }

        public List<StaffRHCEntity> StaffRHCSelectAll()
        {
            string query = "SELECT * FROM StaffRHC";
            staff_r_h_c_list.Clear();
            ConnectAndExecute(query);
            if (dt_staff_r_h_c.Rows.Count > 0)
                foreach (DataRow dr_staff_r_h_c in dt_staff_r_h_c.Rows)
                {
                    staff_r_h_c = GetEntityTableMap(dr_staff_r_h_c);
                    staff_r_h_c_list.Add(staff_r_h_c);
                }

            return staff_r_h_c_list;
        }

        public StaffRHCEntity SelectStaffRHCByID(long staff_i_d)
        {
            staff_r_h_c = new StaffRHCEntity();
            string query = "SELECT * FROM StaffRHC WHERE StaffID = " + staff_i_d;
            ConnectAndExecute(query);

            if (dt_staff_r_h_c.Rows.Count > 0)
                staff_r_h_c = GetEntityTableMap(dt_staff_r_h_c.Rows[0]);

            return staff_r_h_c;
        }

        public long InsertUpdateStaffRHC(StaffRHCEntity staff_r_h_c)
        {
            string query = "";
            long staff_i_d = staff_r_h_c.StaffID;
            StaffRHCEntity existed_staff_r_h_c = SelectStaffRHCByID(staff_i_d);

            if (existed_staff_r_h_c.StaffID == 0)
            {
                query = "INSERT INTO StaffRHC (StaffName,StaffPassword,StaffPhone,StaffAddress,Designation,Qualification,CreatedByID,CreatedDateTime,IsEnabled,LastUpdateDateTime,LastUpdateID,Remarks) VALUES('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}',{10},'{11}')";
                query = string.Format(query, staff_r_h_c.StaffName, staff_r_h_c.StaffPassword, staff_r_h_c.StaffPhone, staff_r_h_c.StaffAddress, staff_r_h_c.Designation, staff_r_h_c.Qualification, staff_r_h_c.CreatedByID, staff_r_h_c.CreatedDateTime, staff_r_h_c.IsEnabled, staff_r_h_c.LastUpdateDateTime, staff_r_h_c.LastUpdateID, staff_r_h_c.Remarks);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM StaffRHC ORDER BY StaffID DESC";
                    ConnectAndExecute(query);

                    if (dt_staff_r_h_c.Rows.Count > 0)
                        staff_i_d = Convert.ToInt64(dt_staff_r_h_c.Rows[0]["StaffID"]);
                }
            }
            else
            {
                query = "UPDATE StaffRHC SET StaffName = '{0}', StaffPassword = '{1}', StaffPhone = '{2}', StaffAddress = '{3}', Designation = '{4}', Qualification = '{5}', CreatedByID = {6}, CreatedDateTime = '{7}', IsEnabled = '{8}', LastUpdateDateTime = '{9}', LastUpdateID = {10}, Remarks = '{11}' WHERE StaffID = " + staff_i_d;
                query = string.Format(query, staff_r_h_c.StaffName, staff_r_h_c.StaffPassword, staff_r_h_c.StaffPhone, staff_r_h_c.StaffAddress, staff_r_h_c.Designation, staff_r_h_c.Qualification, staff_r_h_c.CreatedByID, staff_r_h_c.CreatedDateTime, staff_r_h_c.IsEnabled, staff_r_h_c.LastUpdateDateTime, staff_r_h_c.LastUpdateID, staff_r_h_c.Remarks);
                ConnectAndExecute(query);
                staff_i_d = staff_r_h_c.StaffID;
            }

            return staff_i_d;
        }

        public long DeleteStaffRHCByID(long staff_i_d)
        {
            string query = "DELETE StaffRHC WHERE StaffID = " + staff_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

