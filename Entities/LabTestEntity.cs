using System;

namespace Entities
{
    public class LabTestEntity
    {
        public long LabTestID { get; set; }
        public string LabTestName { get; set; }
        public string NormalRange { get; set; }
        public string Remarks { get; set; }
        public long CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}

