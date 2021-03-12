using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class AsupLog
    {
        public int IdRec { get; set; }
        public DateTime Date { get; set; }
        public string EventType { get; set; }
        public int UserId { get; set; }
        public string Event { get; set; }
        public string MachineName { get; set; }
    }
}
