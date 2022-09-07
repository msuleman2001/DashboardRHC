using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class DeviceReadingsModel
    {
        string connection_string;
        long device_reading_i_d = 0;
        int records_updated = 0;

        List<DeviceReadingsEntity> device_readings_list = new List<DeviceReadingsEntity>();
        DeviceReadingsEntity device_readings = new DeviceReadingsEntity();

        OleDbConnection con_device_readings;
        OleDbCommand com_device_readings;
        OleDbDataAdapter da_device_readings;
        DataTable dt_device_readings;

        public DeviceReadingsModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_device_readings = new OleDbConnection(connection_string);
            com_device_readings = new OleDbCommand();
            da_device_readings = new OleDbDataAdapter();
            dt_device_readings = new DataTable();
        }

        private DeviceReadingsEntity GetEntityTableMap(DataRow dr_device_readings)
        {
            DeviceReadingsEntity device_readings = new DeviceReadingsEntity();
            device_readings.DeviceReadingID = Convert.ToInt64(dr_device_readings["DeviceReadingID"]);
            device_readings.DeviceID = Convert.ToInt64(dr_device_readings["DeviceID"]);
            device_readings.PatientID = Convert.ToInt64(dr_device_readings["PatientID"]);
            device_readings.ReadingValuesJSON = Convert.ToString(dr_device_readings["ReadingValuesJSON"]);
            device_readings.IsUploaded = Convert.ToString(dr_device_readings["IsUploaded"]);
            device_readings.CreatedDateTime = Convert.ToDateTime(dr_device_readings["CreatedDateTime"]);
            device_readings.Remarks = Convert.ToString(dr_device_readings["Remarks"]);

            return device_readings;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_device_readings.State == ConnectionState.Open)
                    con_device_readings.Close();

                con_device_readings.Open();
                com_device_readings.CommandText = query;
                com_device_readings.Connection = con_device_readings;

                if (query.StartsWith("SELECT"))
                {
                    da_device_readings.SelectCommand = com_device_readings;
                    dt_device_readings.Clear();
                    da_device_readings.Fill(dt_device_readings);
                }
                else
                    records_updated = com_device_readings.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_device_readings = new DataTable();
                records_updated = 0;
            }
        }

        public List<DeviceReadingsEntity> DeviceReadingsSelectAll()
        {
            string query = "SELECT * FROM DeviceReadings";
            device_readings_list.Clear();
            ConnectAndExecute(query);
            if (dt_device_readings.Rows.Count > 0)
                foreach (DataRow dr_device_readings in dt_device_readings.Rows)
                {
                    device_readings = GetEntityTableMap(dr_device_readings);
                    device_readings_list.Add(device_readings);
                }

            return device_readings_list;
        }

        public DeviceReadingsEntity SelectDeviceReadingsByID(long device_reading_i_d)
        {
            device_readings = new DeviceReadingsEntity();
            string query = "SELECT * FROM DeviceReadings WHERE DeviceReadingID = " + device_reading_i_d;
            ConnectAndExecute(query);

            if (dt_device_readings.Rows.Count > 0)
                device_readings = GetEntityTableMap(dt_device_readings.Rows[0]);

            return device_readings;
        }

        public long InsertUpdateDeviceReadings(DeviceReadingsEntity device_readings)
        {
            string query = "";
            long device_reading_i_d = device_readings.DeviceReadingID;
            DeviceReadingsEntity existed_device_readings = SelectDeviceReadingsByID(device_reading_i_d);

            if (existed_device_readings.DeviceReadingID == 0)
            {
                query = "INSERT INTO DeviceReadings (DeviceID, PatientID, ReadingValuesJSON, IsUploaded, CreatedDateTime, Remarks) VALUES({0}, {1}, '{2}', '{3}','{4}', '{5}')";
                query = string.Format(query, device_readings.DeviceID, device_readings.PatientID, device_readings.ReadingValuesJSON, device_readings.IsUploaded, device_readings.CreatedDateTime, device_readings.Remarks);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM DeviceReadings ORDER BY DeviceReadingID DESC";
                    ConnectAndExecute(query);

                    if (dt_device_readings.Rows.Count > 0)
                        device_reading_i_d = Convert.ToInt64(dt_device_readings.Rows[0]["DeviceReadingID"]);
                }
            }
            else
            {
                query = "UPDATE DeviceReadings SET DeviceID = {0}, PatientID = {1}, ReadingValuesJSON = '{2}', IsUploaded = '{3}', CreatedDateTime = '{4}', Remarks = '{5}' WHERE DeviceReadingID = " + device_reading_i_d;
                query = string.Format(query, device_readings.DeviceID, device_readings.PatientID,device_readings.ReadingValuesJSON, device_readings.IsUploaded, device_readings.CreatedDateTime, device_readings.Remarks);
                ConnectAndExecute(query);
                device_reading_i_d = device_readings.DeviceReadingID;
            }

            return device_reading_i_d;
        }

        public long DeleteDeviceReadingsByID(long device_reading_i_d)
        {
            string query = "DELETE DeviceReadings WHERE DeviceReadingID = " + device_reading_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

