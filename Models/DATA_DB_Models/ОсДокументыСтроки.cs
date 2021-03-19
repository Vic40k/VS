using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОсДокументыСтроки
    {
        public int Id { get; set; }
        public int DocId { get; set; }
        public DateTime Date { get; set; }
        public int? IdTmc { get; set; }
        public decimal Quantity { get; set; }
        public decimal Summa { get; set; }
        public byte MoveType { get; set; }
        public int? Mol { get; set; }
        public int? SkladId { get; set; }
        public string Account { get; set; }
        public int? UrFaceId { get; set; }
        public int? GrinputId { get; set; }
        public int? NodeId { get; set; }
    }
}
