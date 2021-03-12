using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechTu
    {
        public int? IdRtu { get; set; }
        public string Izgot { get; set; }
        public string TypeWork { get; set; }
        public string KodUp { get; set; }
        public int Status { get; set; }
        public decimal InvNum { get; set; }
        public bool Cpu { get; set; }
        public DateTime? DateSave { get; set; }
        public string Bai { get; set; }
        public string TuType { get; set; }
        public string Operaciya { get; set; }
        public string BaiOwn { get; set; }
        public decimal? AsVvod { get; set; }
        public decimal? AsVyvod { get; set; }
        public string BaiSave { get; set; }
    }
}
