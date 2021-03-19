using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpConfigizg
    {
        public int Id { get; set; }
        public int IdConfig { get; set; }
        public int IdIzgot { get; set; }
        public int KodIzgot { get; set; }
        public DateTime DataCh { get; set; }
        public string UserCh { get; set; }
        public string FieldNam { get; set; }
    }
}
