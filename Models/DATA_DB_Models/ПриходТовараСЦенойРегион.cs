using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходТовараСЦенойРегион
    {
        public string Наименование { get; set; }
        public string Модель { get; set; }
        public string Артикул { get; set; }
        public int? GroupOfGoods { get; set; }
        public int RecordId { get; set; }
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public decimal Количество { get; set; }
        public DateTime ДатаПрихода { get; set; }
        public int UserId { get; set; }
        public int Заявка { get; set; }
        public string Поставщик { get; set; }
        public string НаименованиеОперации { get; set; }
        public string Документ { get; set; }
        public string Ордер { get; set; }
        public int Партия { get; set; }
        public decimal Sebestoimost { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public string НомерГтд { get; set; }
        public decimal Цена { get; set; }
        public decimal? IdФирмы { get; set; }
        public decimal Ssr { get; set; }
        public decimal Цп { get; set; }
        public int Регион { get; set; }
        public int? НомерОфиса { get; set; }
        public string СтранаПроисхожденияПрихода { get; set; }
        public int? НомерЗаказа { get; set; }
        public int? РегионЗаказа { get; set; }
        public int? RecordРекламация { get; set; }
        public string Документ1с { get; set; }
        public decimal? Цп2 { get; set; }
    }
}
