using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HrIndKval
    {
        public DateTime? Data { get; set; }
        public DateTime? DataPr { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string Fam { get; set; }
        public string Fio { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public string KodIzgot { get; set; }
        public string Kval { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public string User { get; set; }
        public bool Delrecord { get; set; }
    }
}
