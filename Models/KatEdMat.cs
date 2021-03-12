﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KatEdMat
    {
        public DateTime? Datsavesql { get; set; }
        public string EdIzm { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public decimal? Koeff { get; set; }
        public string Mat { get; set; }
        public bool Delrecord { get; set; }
    }
}
