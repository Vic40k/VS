using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class GraidZpHid
    {
        public int IdRec { get; set; }
        public int Hid { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal? SummAll { get; set; }
        public decimal? SummOff { get; set; }
        public decimal? SummPer { get; set; }
        public decimal? SummDol { get; set; }
        public decimal? SummBonus { get; set; }
        public decimal? UdOff { get; set; }
        public decimal? UdNoff { get; set; }
    }
}
