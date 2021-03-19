using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlanNew
    {
        public int Id { get; set; }
        public DateTime DateP { get; set; }
        public int Smena { get; set; }
        public DateTime DeadLine { get; set; }
        public int IdSpec { get; set; }
        public int Flag { get; set; }
        public string Articul { get; set; }
        public int Kol { get; set; }
    }
}
