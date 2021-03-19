using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CatDocFile
    {
        public int IdDoc { get; set; }
        public int IdAs { get; set; }
        public bool? LogMail { get; set; }
        public DateTime? DataMail { get; set; }
        public string ExtDoc { get; set; }
        public byte[] Doc { get; set; }
        public int IdUser { get; set; }
        public int? IdIzgot { get; set; }
        public string Prim { get; set; }
        public bool? EnDoc { get; set; }
        public int? IdSoglEn { get; set; }
    }
}
