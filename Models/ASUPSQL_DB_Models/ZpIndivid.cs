using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpIndivid
    {
        public int Id { get; set; }
        public int EdTab { get; set; }
        public int Priznak { get; set; }
        public int IdSt { get; set; }
        public DateTime DatSt { get; set; }
        public DateTime? DatFin { get; set; }
        public string Filtr { get; set; }
        public string Db { get; set; }
        public string Field { get; set; }
    }
}
