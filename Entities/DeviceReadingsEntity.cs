using System;

namespace Entities
{
    public class DeviceReadingsEntity
    {
        public long DeviceReadingID { get; set; }
        public long DeviceID { get; set; }
        public long PatientID { get; set; }
        public string? ReadingValuesJSON { get; set; }   
        public string? IsUploaded { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? Remarks { get; set; }

    }
}

