﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpVypusk
    {
        public int? IdIzgot { get; set; }
        public string KodIzgot { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public decimal? Vypusk { get; set; }
    }
}
