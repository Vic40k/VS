﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class EduCat
    {
        public string Articul { get; set; }
        public string Nam { get; set; }
        public byte[] Pic { get; set; }
        public string Ext { get; set; }
        public int? Cikl { get; set; }
    }
}