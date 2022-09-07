using System;

namespace Entities
{

    public class PatientLabTestEntity
    {
        public long PatientLabTestID { get; set; }
        public long LabTestID { get; set; }
        public long PatientID { get; set; }
        public string LabTestValue { get; set; }
        public string Remarks { get; set; }
        public long CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}
