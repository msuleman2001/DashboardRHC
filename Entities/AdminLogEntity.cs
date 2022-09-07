using System;

namespace Entities
{
    public class AdminLogEntity
    {
        public long AdminLogID { get; set; }
        public long AdminID { get; set; }
        public DateTime LoginDateTime { get; set; }
        public DateTime LogoutDateTime { get; set; }
        public string Remarks { get; set; }

    }
}

