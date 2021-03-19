using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПоставкиДляСверкиРегион
    {
        public string Документ { get; set; }
        public DateTime? FirstДатаОприходования { get; set; }
        public decimal? СуммаПоСчету { get; set; }
        public string Id { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public int Регион { get; set; }
        public int? Expr1 { get; set; }
        public decimal? IdФирмы { get; set; }
    }
}
