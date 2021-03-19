using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WshopSpoper
    {
        public int Id { get; set; }
        public string Articul { get; set; }
        public int IdModOper { get; set; }
        public string Corr { get; set; }
        public decimal Tim { get; set; }
        public decimal Norm { get; set; }
    }
}
