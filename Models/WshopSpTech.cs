using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WshopSpTech
    {
        public int Id { get; set; }
        public int IdMod { get; set; }
        public int IdPar { get; set; }
        public int NomWp { get; set; }
        public int KolPart { get; set; }
        public int Kol { get; set; }
        public int Source { get; set; }
        public string NamWp { get; set; }
        public string KodIzgot { get; set; }
        public int IdArt { get; set; }
    }
}
