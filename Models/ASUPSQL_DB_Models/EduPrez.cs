using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class EduPrez
    {
        public int IdRec { get; set; }
        public int? IdTr { get; set; }
        public int? Pos { get; set; }
        public byte[] Slaide { get; set; }
        public string Ext { get; set; }
    }
}
