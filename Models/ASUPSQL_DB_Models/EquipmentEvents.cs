using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class EquipmentEvents
    {
        public int IdRec { get; set; }
        public string InvNumber { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public double Counter { get; set; }
        public string WorkType { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public string Operator { get; set; }
        public string Engeneer { get; set; }
        public int? UserId { get; set; }
    }
}
