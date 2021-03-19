using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WshopNormAdd
    {
        public int Id { get; set; }
        public int IdPar { get; set; }
        public string Det { get; set; }
        public int NppOper { get; set; }
        public decimal Norm { get; set; }
        public string Articul { get; set; }
        public int New { get; set; }
    }
}
