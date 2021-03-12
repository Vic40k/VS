using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PaintLabourIntensity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public decimal LabourIntensity { get; set; }
    }
}
