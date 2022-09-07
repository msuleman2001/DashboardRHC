using System;

namespace Entities
{
    public class PatientSymptomEntity
    {
        public long PatientSymptomID { get; set; }
        public long PatientID { get; set; }
        public long SymptomID { get; set; }
        public string PatientSymptomValue { get; set; }
        public DateTime DateCreated { get; set; }
        public long CreatedByID { get; set; }
        public string Remarks { get; set; }
    }
}

