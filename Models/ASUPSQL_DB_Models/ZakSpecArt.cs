using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakSpecArt
    {
        public int IdZak { get; set; }
        public int IdGood { get; set; }
        public int KolZ { get; set; }
        public int FlagCh { get; set; }
        public DateTime? DataR { get; set; }
        public int? KolP { get; set; }
        public string Litera { get; set; }
    }
}
