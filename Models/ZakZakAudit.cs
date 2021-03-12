﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakZakAudit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Bai { get; set; }
        public int Prizn { get; set; }
        public string ZakrecId { get; set; }
    }
}
