using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class SecUserPass
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Kod { get; set; }
        public int Ur { get; set; }
        public string User { get; set; }
        public DateTime? TimeActive { get; set; }
        public string Dopusk { get; set; }
        public string Id { get; set; }
        public bool? IsAllowId { get; set; }
        public int IdMainIzgot { get; set; }
        public bool? LogDir { get; set; }
        public string Otv { get; set; }
        public int NLang { get; set; }
        public string KodPass { get; set; }
    }
}
