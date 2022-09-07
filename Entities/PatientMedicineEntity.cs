using System;

namespace Entities
{
    public class PatientMedicineEntity
    {
        public long PatientMedicineID { get; set; }
        public long PatientID { get; set; }
        public long MedicineID { get; set; }
        public string Dosage { get; set; }
        public long CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Remarks { get; set; }
    }
}

