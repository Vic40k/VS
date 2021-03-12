using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpDocXlsx
    {
        public int EdTab { get; set; }
        public byte[] Doc { get; set; }
        public DateTime DateChange { get; set; }
        public string NamDoc { get; set; }
        public string Ext { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateDirector { get; set; }
        public DateTime? DateCurator { get; set; }
    }
}
