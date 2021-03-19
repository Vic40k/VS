using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PlanWeek
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string ExtraCode { get; set; }
        public int? PlantWeek { get; set; }
        public int? FactEweek { get; set; }
        public int? PlantSim { get; set; }
        public int? PlanPn { get; set; }
        public int? FactPn { get; set; }
        public int? PlanVt { get; set; }
        public int? FactVt { get; set; }
        public int? PlanSreda { get; set; }
        public int? FactSreda { get; set; }
        public int? PlanCz { get; set; }
        public int? FactCz { get; set; }
        public int? PlanPt { get; set; }
        public int? FactPt { get; set; }
        public int? PlanSub { get; set; }
        public int? FactSub { get; set; }
        public int? PlanVos { get; set; }
        public int? FactVos { get; set; }
        public string Товар { get; set; }
        public decimal? Цена { get; set; }
        public string КодТовара { get; set; }
        public string Статус { get; set; }
        public int? UserId { get; set; }
    }
}
