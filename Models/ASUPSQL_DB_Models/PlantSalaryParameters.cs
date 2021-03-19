using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlantSalaryParameters
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public int ParameterIndex { get; set; }
        public decimal ParameterValue { get; set; }
        public byte Month { get; set; }
        public int Year { get; set; }
    }
}
