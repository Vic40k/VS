using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class TmcIn
    {
        public int RecordId { get; set; }
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public decimal Количество { get; set; }
        public DateTime ДатаПрихода { get; set; }
        public int UserId { get; set; }
        public int Заявка { get; set; }
        public DateTime? ДатаЗаявки { get; set; }
        public int? Поставщик { get; set; }
        public string НаименованиеОперации { get; set; }
        public string Документ { get; set; }
        public string Ордер { get; set; }
        public int Партия { get; set; }
        public decimal? Sebestoimost { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public string НомерГтд { get; set; }
        public decimal Цена { get; set; }
        public decimal? IdФирмы { get; set; }
        public decimal? Ssr { get; set; }
        public string Валюта { get; set; }
        public string ЕдИзм { get; set; }
        public DateTime? ДатаОплаты { get; set; }
        public int Грузополучатель { get; set; }
        public decimal ЦенаБезНдс { get; set; }
        public decimal КоличествоВЗаказе { get; set; }
        public decimal Итого { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public int Provedeno { get; set; }
        public string IdЕдИзм { get; set; }
    }
}
