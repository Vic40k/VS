using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CartonSheets
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Layers { get; set; }
    }
}
