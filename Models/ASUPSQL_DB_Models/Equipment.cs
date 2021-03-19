using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class Equipment
    {
        public int IdRec { get; set; }
        public string InvNumber { get; set; }
        public string Name { get; set; }
        public int? ModelId { get; set; }
        public int IdIzgot { get; set; }
        public string KodIzgot { get; set; }
        public string AccNumber { get; set; }
        public string ProductionNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public string StartActNumber { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndActNumber { get; set; }
        public bool? HasCounter { get; set; }
        public bool? UseServicePlan { get; set; }
        public int To2 { get; set; }
        public int To3 { get; set; }
        public int To4 { get; set; }
        public bool ServiceByCounter { get; set; }
        public double To2counter { get; set; }
        public double To3counter { get; set; }
        public double To4counter { get; set; }
        public double PurchaseCost { get; set; }
        public int Lifetime { get; set; }
        public bool? InUse { get; set; }
        public string Group { get; set; }
        public string Placement { get; set; }
    }
}
