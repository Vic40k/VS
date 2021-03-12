using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CatalogueResourses
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public int? SortOrder { get; set; }
        public string ResourseName { get; set; }
        public bool InDailyReport { get; set; }
    }
}
