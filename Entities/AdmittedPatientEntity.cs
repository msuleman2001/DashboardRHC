using System;

namespace Entities
{
    public class AdmittedPatientEntity
    {
        public long PatientID { get; set; }
        public long GlobalPatientID { get; set; }
        public string PatientName { get; set; }
        public string AttendentName { get; set; }
        public string PatientCNIC { get; set; }
        public string AttendentPhone { get; set; }
        public string PatientAddress { get; set; }
        public DateTime PatientDOB { get; set; }
        public string PatientGender { get; set; }
        public DateTime AdmissionDate { get; set; }
        public long AdmittedByID { get; set; }
        public DateTime DischargeDateTime { get; set; }
        public long DischargeAdminID { get; set; }
        public string Remarks { get; set; }

    }
}

