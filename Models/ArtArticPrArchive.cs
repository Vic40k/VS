using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ArtArticPrArchive
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string ExtraCode { get; set; }
        public DateTime DateArchive { get; set; }
        public int Idizgot { get; set; }
        public decimal Price { get; set; }
    }
}
