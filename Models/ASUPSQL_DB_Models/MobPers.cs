using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MobPers
    {
        public int IdPers { get; set; }
        public string Dolg { get; set; }
        public string Email { get; set; }
        public int? IdOrg { get; set; }
        public string WorkPlace { get; set; }
    }
}
