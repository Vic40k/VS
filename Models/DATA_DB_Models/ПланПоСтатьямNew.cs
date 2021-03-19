using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПланПоСтатьямNew
    {
        public string СтатьяРасхода { get; set; }
        public decimal? Количество { get; set; }
        public decimal? Цена { get; set; }
        public decimal Сумма { get; set; }
        public decimal? Курс { get; set; }
        public decimal? СуммаРуб { get; set; }
        public short? Приоритетность { get; set; }
        public int? IdЗоны { get; set; }
        public int IdСубсчета { get; set; }
        public short Месяц { get; set; }
        public short Год { get; set; }
        public string Примечание { get; set; }
        public bool? Утвержден { get; set; }
        public bool? Сформирован { get; set; }
        public int RecordId { get; set; }
        public string Код { get; set; }
        public int IdПодразделения { get; set; }
        public DateTime? Дата { get; set; }
        public int? ТипДокумента { get; set; }
        public DateTime? ДатаПоставки { get; set; }
        public int? IdВалюты { get; set; }
        public decimal? Сумма1 { get; set; }
        public decimal? Сумма2 { get; set; }
        public decimal? Сумма3 { get; set; }
        public string МесяцОказанияУслуги { get; set; }
        public int? IdСубсчетаРеестра { get; set; }
        public int? UserId { get; set; }
        public decimal? ЛимитАдмин { get; set; }
        public int BlgTip { get; set; }
        public int АвансТек { get; set; }
        public int IdПроизв { get; set; }
        public decimal? СуммаРубБезНдс { get; set; }
        public int? СтавкаНдс { get; set; }
        public decimal? СуммаНдс { get; set; }
    }
}
