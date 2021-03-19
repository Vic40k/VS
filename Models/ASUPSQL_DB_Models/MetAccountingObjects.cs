using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MetAccountingObjects
    {
        public int ObjectId { get; set; }
        public string ObjectType { get; set; }
        public double? Weight { get; set; }
        public decimal Width { get; set; }
        public decimal? Length { get; set; }
        public decimal Thickness { get; set; }
        public string Name { get; set; }
        public bool Delrecord { get; set; }
    }
}
