using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstКритерииПоставщиков
    {
        public int Id { get; set; }
        public string Наименование { get; set; }
        public string Sign { get; set; }
        public int? TypeId { get; set; }
        public decimal? From { get; set; }
        public decimal? To { get; set; }
        public bool? Deleted { get; set; }
    }
}
