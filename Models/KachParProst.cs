﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KachParProst
    {
        public int Idrec { get; set; }
        public int Idizgot { get; set; }
        public string KodIzgot { get; set; }
        public decimal Nom { get; set; }
        public string Prostoy { get; set; }
        public DateTime Datsavesql { get; set; }
        public bool Delrecord { get; set; }
    }
}
