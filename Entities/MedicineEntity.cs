using System;

namespace Entities
{
    public class MedicineEntity
    {
        public long MedicineID { get; set; }
        public string MedicineName { get; set; }
        public string Potency { get; set; }
        public string Remarks { get; set; }
        public long CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}

