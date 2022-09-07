using System;

namespace Entities
{
    public class PatientVitalsEntity
    {
        public long PatientVitalID { get; set; }
        public long PatientID { get; set; }
        public string VitalName { get; set; }
        public string VitalValue { get; set; }
        public DateTime VitalDateTime { get; set; }
    }
}

