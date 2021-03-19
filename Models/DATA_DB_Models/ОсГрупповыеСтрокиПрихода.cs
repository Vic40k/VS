using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОсГрупповыеСтрокиПрихода
    {
        public int Id { get; set; }
        public int? DocId { get; set; }
        public int? IdTmc { get; set; }
        public string Document { get; set; }
        public DateTime? DateDoc { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Summa { get; set; }
        public string IdEdIzm { get; set; }
        public bool IsProcessed { get; set; }
        public int? PrixodRecordId { get; set; }
        public int CurrencyId { get; set; }
    }
}
