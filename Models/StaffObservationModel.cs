using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class StaffObservationModel
    {
        string connection_string;
        long staff_observation_i_d = 0;
        int records_updated = 0;

        List<StaffObservationEntity> staff_observation_list = new List<StaffObservationEntity>();
        StaffObservationEntity staff_observation = new StaffObservationEntity();

        OleDbConnection con_staff_observation;
        OleDbCommand com_staff_observation;
        OleDbDataAdapter da_staff_observation;
        DataTable dt_staff_observation;

        public StaffObservationModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_staff_observation = new OleDbConnection(connection_string);
            com_staff_observation = new OleDbCommand();
            da_staff_observation = new OleDbDataAdapter();
            dt_staff_observation = new DataTable();
        }

        private StaffObservationEntity GetEntityTableMap(DataRow dr_staff_observation)
        {
            StaffObservationEntity staff_observation = new StaffObservationEntity();
            staff_observation.StaffObservationID = Convert.ToInt64(dr_staff_observation["StaffObservationID"]);
            staff_observation.StaffObserationByID = Convert.ToInt64(dr_staff_observation["StaffObserationByID"]);
            staff_observation.PatientID = Convert.ToInt64(dr_staff_observation["PatientID"]);
            staff_observation.StaffObservationDetails = Convert.ToString(dr_staff_observation["StaffObservationDetails"]);
            staff_observation.Remarks = Convert.ToString(dr_staff_observation["Remarks"]);
            staff_observation.AdminID = Convert.ToInt64(dr_staff_observation["AdminID"]);
            staff_observation.CreatedDateTime = Convert.ToDateTime(dr_staff_observation["CreatedDateTime"]);

            return staff_observation;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_staff_observation.State == ConnectionState.Open)
                    con_staff_observation.Close();

                con_staff_observation.Open();
                com_staff_observation.CommandText = query;
                com_staff_observation.Connection = con_staff_observation;

                if (query.StartsWith("SELECT"))
                {
                    da_staff_observation.SelectCommand = com_staff_observation;
                    dt_staff_observation.Clear();
                    da_staff_observation.Fill(dt_staff_observation);
                }
                else
                    records_updated = com_staff_observation.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_staff_observation = new DataTable();
                records_updated = 0;
            }
        }

        public List<StaffObservationEntity> StaffObservationSelectAll()
        {
            string query = "SELECT * FROM StaffObservation";
            staff_observation_list.Clear();
            ConnectAndExecute(query);
            if (dt_staff_observation.Rows.Count > 0)
                foreach (DataRow dr_staff_observation in dt_staff_observation.Rows)
                {
                    staff_observation = GetEntityTableMap(dr_staff_observation);
                    staff_observation_list.Add(staff_observation);
                }

            return staff_observation_list;
        }

        public StaffObservationEntity SelectStaffObservationByID(long staff_observation_i_d)
        {
            staff_observation = new StaffObservationEntity();
            string query = "SELECT * FROM StaffObservation WHERE StaffObservationID = " + staff_observation_i_d;
            ConnectAndExecute(query);

            if (dt_staff_observation.Rows.Count > 0)
                staff_observation = GetEntityTableMap(dt_staff_observation.Rows[0]);

            return staff_observation;
        }

        public long InsertUpdateStaffObservation(StaffObservationEntity staff_observation)
        {
            string query = "";
            long staff_observation_i_d = staff_observation.StaffObservationID;
            StaffObservationEntity existed_staff_observation = SelectStaffObservationByID(staff_observation_i_d);

            if (existed_staff_observation.StaffObservationID == 0)
            {
                query = "INSERT INTO StaffObservation (StaffObserationByID, PatientID, StaffObservationDetails, Remarks, AdminID, CreatedDateTime) VALUES({0}, {1}, '{2}', '{3}', {4}, '{5}')";
                query = string.Format(query, staff_observation.StaffObserationByID, staff_observation.PatientID, staff_observation.StaffObservationDetails, staff_observation.Remarks, staff_observation.AdminID, staff_observation.CreatedDateTime);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM StaffObservation ORDER BY StaffObservationID DESC";
                    ConnectAndExecute(query);

                    if (dt_staff_observation.Rows.Count > 0)
                        staff_observation_i_d = Convert.ToInt64(dt_staff_observation.Rows[0]["StaffObservationID"]);
                }
            }
            else
            {
                query = "UPDATE StaffObservation SET StaffObserationByID = {0}, PatientID = {1} StaffObservationDetails = '{2}', Remarks = '{3}', AdminID = {4}, CreatedDateTime = {5} WHERE StaffObservationID = " + staff_observation_i_d;
                query = string.Format(query, staff_observation.StaffObserationByID, staff_observation.StaffObservationDetails, staff_observation.Remarks, staff_observation.CreatedDateTime);
                ConnectAndExecute(query);
                staff_observation_i_d = staff_observation.StaffObservationID;
            }

            return staff_observation_i_d;
        }

        public long DeleteStaffObservationByID(long staff_observation_i_d)
        {
            string query = "DELETE StaffObservation WHERE StaffObservationID = " + staff_observation_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

