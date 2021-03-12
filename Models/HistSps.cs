using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HistSps
    {
        public int IdDet { get; set; }
        public int AsSps { get; set; }
        public int IdKem { get; set; }
        public int IdBai { get; set; }
        public DateTime DataChange { get; set; }
    }
}
