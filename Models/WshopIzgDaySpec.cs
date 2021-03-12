using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WshopIzgDaySpec
    {
        public int Id { get; set; }
        public int IdRep { get; set; }
        public int IdSpec { get; set; }
        public int FlagSpec { get; set; }
        public string IdPlan { get; set; }
        public int? Kol { get; set; }
    }
}
