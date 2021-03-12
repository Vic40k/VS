using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechDetApAdd
    {
        public int Id { get; set; }
        public int Iddetail { get; set; }
        public int Idcell { get; set; }
        public int Idoperation { get; set; }
        public decimal? OperationNumber { get; set; }
        public int Idequipment { get; set; }
        public decimal? Timing { get; set; }
        public int? Advance { get; set; }
        public int Idunit { get; set; }
    }
}
