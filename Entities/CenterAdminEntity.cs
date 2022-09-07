using System;

namespace Entities
{
    public class CenterAdminEntity
    {
        public long AdminID { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public string AdminImage { get; set; }
        public long CreatedByID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string IsEnabled { get; set; }
        public string Remarks { get; set; }

    }
}

