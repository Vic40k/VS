using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KonDetVes
    {
        public string Det { get; set; }
        public decimal Ves { get; set; }
        public string Mat { get; set; }
        public DateTime DateVes { get; set; }
        public string BaiVes { get; set; }
    }
}
