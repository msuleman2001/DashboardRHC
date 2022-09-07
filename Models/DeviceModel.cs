using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class DeviceModel
    {
        string connection_string;
        long device_i_d = 0;
        int records_updated = 0;

        List<DeviceEntity> device_list = new List<DeviceEntity>();
        DeviceEntity device = new DeviceEntity();

        OleDbConnection con_device;
        OleDbCommand com_device;
        OleDbDataAdapter da_device;
        DataTable dt_device;

        public DeviceModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_device = new OleDbConnection(connection_string);
            com_device = new OleDbCommand();
            da_device = new OleDbDataAdapter();
            dt_device = new DataTable();
        }

        private DeviceEntity GetEntityTableMap(DataRow dr_device)
        {
            DeviceEntity device = new DeviceEntity();
            device.DeviceID = Convert.ToInt64(dr_device["DeviceID"]);
            device.DeviceName = Convert.ToString(dr_device["DeviceName"]);
            device.DeviceMAC = Convert.ToString(dr_device["DeviceMAC"]);
            device.DeviceIP = Convert.ToString(dr_device["DeviceIP"]);
            device.Sensors = Convert.ToString(dr_device["Sensors"]);
            device.DeviceRecievedByID = Convert.ToInt64(dr_device["DeviceRecievedByID"]);
            device.DeviceRecievedDateTime = Convert.ToDateTime(dr_device["DeviceRecievedDateTime"]);
            device.IsEnabled = Convert.ToString(dr_device["IsEnabled"]);
            device.DeviceDisableDate = Convert.ToDateTime(dr_device["DeviceDisableDate"]);
            device.Remarks = Convert.ToString(dr_device["Remarks"]);

            return device;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_device.State == ConnectionState.Open)
                    con_device.Close();

                con_device.Open();
                com_device.CommandText = query;
                com_device.Connection = con_device;

                if (query.StartsWith("SELECT"))
                {
                    da_device.SelectCommand = com_device;
                    dt_device.Clear();
                    da_device.Fill(dt_device);
                }
                else
                    records_updated = com_device.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_device = new DataTable();
                records_updated = 0;
            }
        }

        public List<DeviceEntity> DeviceSelectAll()
        {
            string query = "SELECT * FROM Device";
            device_list.Clear();
            ConnectAndExecute(query);
            if (dt_device.Rows.Count > 0)
                foreach (DataRow dr_device in dt_device.Rows)
                {
                    device = GetEntityTableMap(dr_device);
                    device_list.Add(device);
                }

            return device_list;
        }

        public DeviceEntity SelectDeviceByID(long device_i_d)
        {
            device = new DeviceEntity();
            string query = "SELECT * FROM Device WHERE DeviceID = " + device_i_d;
            ConnectAndExecute(query);

            if (dt_device.Rows.Count > 0)
                device = GetEntityTableMap(dt_device.Rows[0]);

            return device;
        }

        public long InsertUpdateDevice(DeviceEntity device)
        {
            string query = "";
            long device_i_d = device.DeviceID;
            DeviceEntity existed_device = SelectDeviceByID(device_i_d);

            if (existed_device.DeviceID == 0)
            {
                query = "INSERT INTO Device (DeviceName,DeviceMAC,DeviceIP,Sensors,DeviceRecievedByID,DeviceRecievedDateTime,IsEnabled,DeviceDisableDate,Remarks) VALUES('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}')";
                query = string.Format(query, device.DeviceName, device.DeviceMAC, device.DeviceIP, device.Sensors, device.DeviceRecievedByID, device.DeviceRecievedDateTime, device.IsEnabled, device.DeviceDisableDate, device.Remarks);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM Device ORDER BY DeviceID DESC";
                    ConnectAndExecute(query);

                    if (dt_device.Rows.Count > 0)
                        device_i_d = Convert.ToInt64(dt_device.Rows[0]["DeviceID"]);
                }
            }
            else
            {
                query = "UPDATE Device SET DeviceName = '{0}', DeviceMAC = '{1}', DeviceIP = '{2}', Sensors = '{3}', DeviceRecievedByID = {4}, DeviceRecievedDateTime = '{5}', IsEnabled = '{6}', DeviceDisableDate = '{7}', Remarks = '{8}' WHERE DeviceID = " + device_i_d;
                query = string.Format(query, device.DeviceName, device.DeviceMAC, device.DeviceIP, device.Sensors, device.DeviceRecievedByID, device.DeviceRecievedDateTime, device.IsEnabled, device.DeviceDisableDate, device.Remarks);
                ConnectAndExecute(query);
                device_i_d = device.DeviceID;
            }

            return device_i_d;
        }

        public long DeleteDeviceByID(long device_i_d)
        {
            string query = "DELETE Device WHERE DeviceID = " + device_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

