using System;

namespace Entities
{
    public class DeviceAttachmentEntity
    {
        public long DeviceAttachmentID { get; set; }
        public long DeviceID { get; set; }
        public long PatientID { get; set; }
        public DateTime AttachmentDateTime { get; set; }
        public long AttachByID { get; set; }
        public DateTime DetachmentDateTime { get; set; }
        public long DetachByID { get; set; }
        public string Remarks { get; set; }

    }
}

