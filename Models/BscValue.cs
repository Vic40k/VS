﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class BscValue
    {
        public int Id { get; set; }
        public int IdTarget { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Value { get; set; }
        public int UserInput { get; set; }
    }
}
