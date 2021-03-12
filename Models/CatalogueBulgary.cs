using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CatalogueBulgary
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public int? IdmeasureUnit { get; set; }
        public decimal? Price { get; set; }
    }
}
