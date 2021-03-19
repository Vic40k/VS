using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ArtPrGroupSections
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public byte? DaysFromWeldToBuild { get; set; }
        public int? PlantType { get; set; }
        public int? Unit { get; set; }
        public string SectionTitle { get; set; }
        public bool InReport { get; set; }
        public byte ScheduleType { get; set; }
    }
}
