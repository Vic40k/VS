using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class Applications
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string CurrentVersion { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Path { get; set; }
        public string InstallTo { get; set; }
    }
}
