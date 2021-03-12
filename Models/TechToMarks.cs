using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechToMarks
    {
        public int IdIzgot { get; set; }
        public string KodIzgot { get; set; }
        public DateTime Data { get; set; }
        public int Smena { get; set; }
        public int Equipment { get; set; }
        public int Responsible { get; set; }
        public int Director { get; set; }
        public double Mark { get; set; }
        public int UserId { get; set; }
    }
}
