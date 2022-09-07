using System;

namespace Entities
{
    public class StaffObservationEntity
    {
        public long StaffObservationID { get; set; }
        public long StaffObserationByID { get; set; }
        public long PatientID { get; set; }
        public string StaffObservationDetails { get; set; }
        public string Remarks { get; set; }
        public long AdminID { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}

