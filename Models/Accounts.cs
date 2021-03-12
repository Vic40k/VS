using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class Accounts
    {
        public int IdRec { get; set; }
        public int IdIzgot { get; set; }
        public string KodIzgot { get; set; }
        public DateTime Period { get; set; }
        public int Tab { get; set; }
        public int Account { get; set; }
        public int? OrgId { get; set; }
        public int? Days { get; set; }
        public decimal? Hours { get; set; }
        public decimal Value { get; set; }
        public double? Param1 { get; set; }
        public double? Param2 { get; set; }
        public int? UserId { get; set; }
        public string Source { get; set; }
        public int Status { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string Comments { get; set; }
    }
}
