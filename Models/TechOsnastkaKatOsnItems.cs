using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaKatOsnItems
    {
        public int Key { get; set; }
        public int Keyosn { get; set; }
        public string Snom { get; set; }
        public int Keyorder { get; set; }
        public string Inventorynumber { get; set; }
        public DateTime? Proddate { get; set; }
        public string KodIzgot { get; set; }
        public DateTime? Checkdate { get; set; }
        public int? Status { get; set; }
        public bool? Discard { get; set; }
        public DateTime? Datediscard { get; set; }
        public int? Fio { get; set; }
        public string Note { get; set; }
        public int ItemIdizgot { get; set; }
        public bool? Notified { get; set; }
    }
}
