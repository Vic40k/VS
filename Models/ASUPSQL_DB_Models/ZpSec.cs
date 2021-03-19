using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpSec
    {
        public int Id { get; set; }
        public int Hid { get; set; }
        public int IdObj { get; set; }
        public int Access { get; set; }
        public int ReadOnly { get; set; }
    }
}
