using System;

namespace Entities
{
    public class DeviceEntity
    {
        public long DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string DeviceMAC { get; set; }
        public string DeviceIP { get; set; }
        public string Sensors { get; set; }
        public long DeviceRecievedByID { get; set; }
        public DateTime DeviceRecievedDateTime { get; set; }
        public string IsEnabled { get; set; }
        public DateTime DeviceDisableDate { get; set; }
        public string Remarks { get; set; }

    }
}

