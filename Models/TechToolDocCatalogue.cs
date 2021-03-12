using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechToolDocCatalogue
    {
        public int Id { get; set; }
        public int Idtool { get; set; }
        public int Iduser { get; set; }
        public DateTime? DateAddDoc { get; set; }
        public byte[] Doc { get; set; }
        public string DocFileExtention { get; set; }
        public string Description { get; set; }
        public int? SortNumber { get; set; }
        public byte DocType { get; set; }
    }
}
