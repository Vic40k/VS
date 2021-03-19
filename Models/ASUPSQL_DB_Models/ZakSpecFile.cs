using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakSpecFile
    {
        public int IdFile { get; set; }
        public int IdZak { get; set; }
        public byte[] FileData { get; set; }
        public string NameFile { get; set; }
        public string Ext { get; set; }
        public int FlagCh { get; set; }
        public string FileTmp { get; set; }
    }
}
