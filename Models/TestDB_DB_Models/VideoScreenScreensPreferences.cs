using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.TestDB_DB_Models
{
    public partial class VideoScreenScreensPreferences
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool AutoScroll { get; set; }
        public int PageToShowFrom { get; set; }
        public int PageToShowTo { get; set; }
        public int ScrollInterval { get; set; }
        public int UpdatePeriod { get; set; }
    }
}
