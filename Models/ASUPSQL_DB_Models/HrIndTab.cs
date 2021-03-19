using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HrIndTab
    {
        public DateTime? Datsavesql { get; set; }
        public string Fio { get; set; }
        public int? Id { get; set; }
        public int? Idapax { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public int? IdrecIndk { get; set; }
        public int? TabNom { get; set; }
        public string TabNoms { get; set; }
        public bool Delrecord { get; set; }
    }
}
