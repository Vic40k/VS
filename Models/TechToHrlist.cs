using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechToHrlist
    {
        public int IdRec { get; set; }
        public int IdIzgot { get; set; }
        public DateTime Period { get; set; }
        public string Fio { get; set; }
        public decimal AvgMark { get; set; }
        public int? RedCount { get; set; }
        public int? YellowCount { get; set; }
        public int? GreenCount { get; set; }
        public bool? Checked { get; set; }
        public bool IsOtv { get; set; }
    }
}
