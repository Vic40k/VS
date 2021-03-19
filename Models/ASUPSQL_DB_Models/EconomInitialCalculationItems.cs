using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class EconomInitialCalculationItems
    {
        public int Id { get; set; }
        public int Idarticle { get; set; }
        public byte ItemType { get; set; }
        public int Iditem { get; set; }
        public decimal? WeightPrevious { get; set; }
        public byte? ExpensePercent { get; set; }
        public int? IdpriceList { get; set; }
        public int? Idclient { get; set; }
        public int? Idcompany { get; set; }
        public byte SetType { get; set; }
        public decimal? Weight { get; set; }
        public byte ReferenceId { get; set; }
        public decimal? Price { get; set; }
    }
}
