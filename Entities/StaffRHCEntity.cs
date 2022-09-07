using System;

namespace Entities
{
    public class StaffRHCEntity
    {
        public long StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffPassword { get; set; }
        public string StaffPhone { get; set; }
        public string StaffAddress { get; set; }
        public string Designation { get; set; }
        public string Qualification { get; set; }
        public long CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string IsEnabled { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public long LastUpdateID { get; set; }
        public string Remarks { get; set; }

    }
}


