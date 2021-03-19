using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class AuditSklad
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecordId { get; set; }
        public string Nakl { get; set; }
        public string Sf { get; set; }
        public int? SkladId { get; set; }
        public decimal? Summa { get; set; }
        public decimal? Count { get; set; }
        public string Gtd { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? IdTmc { get; set; }
        public int? Партия { get; set; }
    }
}
