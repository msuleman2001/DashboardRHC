using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;

using Entities;

namespace Models
{
    public class DeviceAttachmentModel
    {
        string connection_string;
        long device_attachment_i_d = 0;
        int records_updated = 0;

        List<DeviceAttachmentEntity> device_attachment_list = new List<DeviceAttachmentEntity>();
        DeviceAttachmentEntity device_attachment = new DeviceAttachmentEntity();

        OleDbConnection con_device_attachment;
        OleDbCommand com_device_attachment;
        OleDbDataAdapter da_device_attachment;
        DataTable dt_device_attachment;

        public DeviceAttachmentModel()
        {
            connection_string = File.ReadAllText("constr.txt");
            con_device_attachment = new OleDbConnection(connection_string);
            com_device_attachment = new OleDbCommand();
            da_device_attachment = new OleDbDataAdapter();
            dt_device_attachment = new DataTable();
        }

        private DeviceAttachmentEntity GetEntityTableMap(DataRow dr_device_attachment)
        {
            DeviceAttachmentEntity device_attachment = new DeviceAttachmentEntity();
            device_attachment.DeviceAttachmentID = Convert.ToInt64(dr_device_attachment["DeviceAttachmentID"]);
            device_attachment.DeviceID = Convert.ToInt64(dr_device_attachment["DeviceID"]);
            device_attachment.PatientID = Convert.ToInt64(dr_device_attachment["PatientID"]);
            device_attachment.AttachmentDateTime = Convert.ToDateTime(dr_device_attachment["AttachmentDateTime"]);
            device_attachment.AttachByID = Convert.ToInt64(dr_device_attachment["AttachByID"]);
            device_attachment.DetachmentDateTime = Convert.ToDateTime(dr_device_attachment["DetachmentDateTime"]);
            device_attachment.DetachByID = Convert.ToInt64(dr_device_attachment["DetachByID"]);
            device_attachment.Remarks = Convert.ToString(dr_device_attachment["Remarks"]);

            return device_attachment;

        }

        private void ConnectAndExecute(string query)
        {
            try
            {
                records_updated = 0;
                if (con_device_attachment.State == ConnectionState.Open)
                    con_device_attachment.Close();

                con_device_attachment.Open();
                com_device_attachment.CommandText = query;
                com_device_attachment.Connection = con_device_attachment;

                if (query.StartsWith("SELECT"))
                {
                    da_device_attachment.SelectCommand = com_device_attachment;
                    dt_device_attachment.Clear();
                    da_device_attachment.Fill(dt_device_attachment);
                }
                else
                    records_updated = com_device_attachment.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                dt_device_attachment = new DataTable();
                records_updated = 0;
            }
        }

        public List<DeviceAttachmentEntity> DeviceAttachmentSelectAll()
        {
            string query = "SELECT * FROM DeviceAttachment";
            device_attachment_list.Clear();
            ConnectAndExecute(query);
            if (dt_device_attachment.Rows.Count > 0)
                foreach (DataRow dr_device_attachment in dt_device_attachment.Rows)
                {
                    device_attachment = GetEntityTableMap(dr_device_attachment);
                    device_attachment_list.Add(device_attachment);
                }

            return device_attachment_list;
        }

        public DeviceAttachmentEntity SelectDeviceAttachmentByID(long device_attachment_i_d)
        {
            device_attachment = new DeviceAttachmentEntity();
            string query = "SELECT * FROM DeviceAttachment WHERE DeviceAttachmentID = " + device_attachment_i_d;
            ConnectAndExecute(query);

            if (dt_device_attachment.Rows.Count > 0)
                device_attachment = GetEntityTableMap(dt_device_attachment.Rows[0]);

            return device_attachment;
        }

        public long InsertUpdateDeviceAttachment(DeviceAttachmentEntity device_attachment)
        {
            string query = "";
            long device_attachment_i_d = device_attachment.DeviceAttachmentID;
            DeviceAttachmentEntity existed_device_attachment = SelectDeviceAttachmentByID(device_attachment_i_d);

            if (existed_device_attachment.DeviceAttachmentID == 0)
            {
                query = "INSERT INTO DeviceAttachment (DeviceID,PatientID,AttachmentDateTime,AttachByID,DetachmentDateTime,DetachByID,Remarks) VALUES({0},{1},'{2}',{3},'{4}',{5},'{6}')";
                query = string.Format(query, device_attachment.DeviceID, device_attachment.PatientID, device_attachment.AttachmentDateTime, device_attachment.AttachByID, device_attachment.DetachmentDateTime, device_attachment.DetachByID, device_attachment.Remarks);
                ConnectAndExecute(query);

                if (records_updated > 0)
                {
                    query = "SELECT TOP 1 * FROM DeviceAttachment ORDER BY DeviceAttachmentID DESC";
                    ConnectAndExecute(query);

                    if (dt_device_attachment.Rows.Count > 0)
                        device_attachment_i_d = Convert.ToInt64(dt_device_attachment.Rows[0]["DeviceAttachmentID"]);
                }
            }
            else
            {
                query = "UPDATE DeviceAttachment SET DeviceID = {0}, PatientID = {1}, AttachmentDateTime = '{2}', AttachByID = {3}, DetachmentDateTime = '{4}', DetachByID = {5}, Remarks = '{6}' WHERE DeviceAttachmentID = " + device_attachment_i_d;
                query = string.Format(query, device_attachment.DeviceID, device_attachment.PatientID, device_attachment.AttachmentDateTime, device_attachment.AttachByID, device_attachment.DetachmentDateTime, device_attachment.DetachByID, device_attachment.Remarks);
                ConnectAndExecute(query);
                device_attachment_i_d = device_attachment.DeviceAttachmentID;
            }

            return device_attachment_i_d;
        }

        public long DeleteDeviceAttachmentByID(long device_attachment_i_d)
        {
            string query = "DELETE DeviceAttachment WHERE DeviceAttachmentID = " + device_attachment_i_d;
            ConnectAndExecute(query);
            return records_updated;
        }
    }
}

