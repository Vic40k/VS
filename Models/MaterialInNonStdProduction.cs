using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MaterialInNonStdProduction
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public decimal? Quantity { get; set; }
        public int? IdarticleInOrder { get; set; }
        public int MaterialType { get; set; }
    }
}
