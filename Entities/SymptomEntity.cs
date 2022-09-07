using System;

namespace Entities
{
    public class SymptomEntity
    {
        public long SymptomID { get; set; }
        public string SymptomTitle { get; set; }
        public string CategoryAndValue { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string SymptomRemarks { get; set; }
        public string SymptomEnabled { get; set; }
        public long CreatedByID { get; set; }
    }
}

