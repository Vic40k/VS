using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ArticulComplectation
    {
        public int GoodId { get; set; }
        public string Detail { get; set; }
        public string CustomName { get; set; }
        public string CustomNameEn { get; set; }
        public double Quantity { get; set; }
        public string MeasureUnit { get; set; }
    }
}
