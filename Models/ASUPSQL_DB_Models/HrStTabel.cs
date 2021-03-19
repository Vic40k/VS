using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HrStTabel
    {
        public DateTime? DataSt { get; set; }
        public DateTime? Datsavesql { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public decimal? Period { get; set; }
        public decimal? Smena { get; set; }
        public string Tabel { get; set; }
        public string TimeF1 { get; set; }
        public string TimeF2 { get; set; }
        public string TimeF3 { get; set; }
        public string TimeS1 { get; set; }
        public string TimeS2 { get; set; }
        public string TimeS3 { get; set; }
        public bool Delrecord { get; set; }
    }
}
