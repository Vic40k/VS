﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class VNakArtic
    {
        public long? RowNumber { get; set; }
        public string Articul { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string DopCod { get; set; }
        public string Group { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public decimal? Kol { get; set; }
        public string Nakl { get; set; }
        public decimal? Net { get; set; }
        public decimal? Pos { get; set; }
        public decimal? Price { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public string Prn { get; set; }
        public decimal? Smena { get; set; }
        public bool? Spisanie { get; set; }
        public bool Delrecord { get; set; }
    }
}
