using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechTudata
    {
        public int IdRec { get; set; }
        public int IdRtu { get; set; }
        public string Izgot { get; set; }
        public string TypeWork { get; set; }
        public int? TypeDoc { get; set; }
        public DateTime? DataSave { get; set; }
        public string Bai { get; set; }
        public string ExtData { get; set; }
        public byte[] FileData { get; set; }
        public string Det { get; set; }
        public string NamDet { get; set; }
        public string UpCod { get; set; }
        public bool? Noneed { get; set; }
    }
}
