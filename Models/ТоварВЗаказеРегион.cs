using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ТоварВЗаказеРегион
    {
        public int IdТовара { get; set; }
        public int НомерПокупателя { get; set; }
        public float Количество { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int UserId { get; set; }
        public int RecordId { get; set; }
        public int Регион { get; set; }
        public int? Idrec { get; set; }
        public int? Idzak { get; set; }
        public string АртикулКлиента { get; set; }
        public string НаименованиеКлиента { get; set; }
        public string Описание { get; set; }
        public string АртикулБазовый { get; set; }
        public decimal? Цена { get; set; }
        public DateTime? AddedDate { get; set; }
        public string AddedBy { get; set; }
        public string Title { get; set; }
        public string Sku { get; set; }
        public decimal? Цр { get; set; }
        public decimal? Nds { get; set; }
    }
}
