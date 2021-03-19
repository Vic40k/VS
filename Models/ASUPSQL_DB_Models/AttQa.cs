using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class AttQa
    {
        public int IdQ { get; set; }
        public string Qwes { get; set; }
        public string Ans { get; set; }
        public string Bai { get; set; }
        public DateTime DateS { get; set; }
        public int? SprIdGr { get; set; }
        public byte[] Pic { get; set; }
    }
}
