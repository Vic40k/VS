using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class OrderListKazanlyk
    {
        public int Id { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Customer { get; set; }
        public int? Plant1 { get; set; }
        public int? Plant2 { get; set; }
        public int? Plant3 { get; set; }
        public int? Plant4 { get; set; }
        public int? Plant5 { get; set; }
        public int? Plan1 { get; set; }
        public int? Fact1 { get; set; }
        public int? Plan2 { get; set; }
        public int? Fact2 { get; set; }
        public int? Plan3 { get; set; }
        public int? Fact3 { get; set; }
        public int? Plan4 { get; set; }
        public int? Fact4 { get; set; }
        public int? Plan5 { get; set; }
        public int? Fact5 { get; set; }
        public decimal? Balance1 { get; set; }
        public decimal? Balance2 { get; set; }
        public decimal? Balance3 { get; set; }
        public decimal? Balance4 { get; set; }
        public decimal? Balance5 { get; set; }
        public DateTime? DatePlan { get; set; }
        public DateTime? DateNewPlan { get; set; }
        public DateTime? DateFact { get; set; }
        public int? HeadShip { get; set; }
        public decimal? Income { get; set; }
        public int? UserId { get; set; }
        public string Tovar { get; set; }
        public int? Inv1 { get; set; }
        public int? Inv2 { get; set; }
        public int? Inv3 { get; set; }
        public int? Inv4 { get; set; }
        public int? Inv5 { get; set; }
        public decimal? КолЖел1 { get; set; }
        public decimal? КолЖел2 { get; set; }
        public decimal? КолЖел3 { get; set; }
        public decimal? КолЖел4 { get; set; }
        public decimal? КолЖел5 { get; set; }
        public decimal? BalOst { get; set; }
        public string TovarTovar { get; set; }
        public string Artikul { get; set; }
        public decimal? ЦенаПередачи { get; set; }
        public decimal? ЦенаИнвойса { get; set; }
        public string OrderNo { get; set; }
        public string Статус { get; set; }
        public string СтатусТовара { get; set; }
    }
}
