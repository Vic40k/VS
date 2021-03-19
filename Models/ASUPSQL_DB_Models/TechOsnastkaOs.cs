using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaOs
    {
        public int Key { get; set; }
        public int Keyorder { get; set; }
        public string NumberName { get; set; }
        public bool? Ownproduction { get; set; }
        public decimal? Price { get; set; }
        public byte? FlagDiscard { get; set; }
        public DateTime? Date { get; set; }
        public string Inventorynumber { get; set; }
        public decimal? PriceOc { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public int? Cell { get; set; }
        public DateTime? DateAcceptance { get; set; }
    }
}
