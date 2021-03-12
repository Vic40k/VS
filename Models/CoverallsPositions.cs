using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CoverallsPositions
    {
        public int IdRec { get; set; }
        public int PositionId { get; set; }
        public int NormId1 { get; set; }
        public int NormId2 { get; set; }
        public int NormId3 { get; set; }
        public int Count { get; set; }
        public int UsefulPeriod { get; set; }
    }
}
