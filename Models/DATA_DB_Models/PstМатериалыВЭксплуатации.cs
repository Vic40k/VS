using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstМатериалыВЭксплуатации
    {
        public int Id { get; set; }
        public int НомерТребования { get; set; }
        public int TypeSpisId { get; set; }
        public int IdTmc { get; set; }
        public DateTime Date { get; set; }
        public decimal? Count { get; set; }
        public int Hid { get; set; }
        public int? FinId { get; set; }
        public int Status { get; set; }
        public int? RecIdRashod { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public int FactoryId { get; set; }
    }
}
