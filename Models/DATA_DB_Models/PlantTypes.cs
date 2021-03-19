using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PlantTypes
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public string PlantType { get; set; }
        public int? Idchief { get; set; }
        public int? Sort1 { get; set; }
    }
}
