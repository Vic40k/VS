using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ConfFiles
    {
        public int Id { get; set; }
        public string NamFile { get; set; }
        public byte[] DocBin { get; set; }
        public string Ext { get; set; }
        public int Group { get; set; }
    }
}
