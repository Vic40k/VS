using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПланПриходовПоСтатьям
    {
        public string СтатьяРасхода { get; set; }
        public decimal? Количество { get; set; }
        public decimal? Цена { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? Курс { get; set; }
        public decimal? СуммаРуб { get; set; }
        public decimal? Процент { get; set; }
        public int? IdЗоны { get; set; }
        public int? IdСубсчета { get; set; }
        public short? Месяц { get; set; }
        public short? Год { get; set; }
        public string Примечание { get; set; }
        public bool? Утвержден { get; set; }
        public bool? Сформирован { get; set; }
        public int RecordId { get; set; }
        public string Код { get; set; }
        public int? IdПодразделения { get; set; }
        public DateTime? Дата { get; set; }
        public short? Вероятность { get; set; }
        public int? IdКонтрагента { get; set; }
        public decimal? Сумма1 { get; set; }
        public decimal? Сумма2 { get; set; }
        public decimal? Сумма3 { get; set; }
        public string МесяцОказанияУслуги { get; set; }
        public int? IdСубсчетаРеестра { get; set; }
        public decimal? Сумма1Евро { get; set; }
        public decimal? Сумма2Евро { get; set; }
        public decimal? Сумма3Евро { get; set; }
        public int BlgTip { get; set; }
        public int IdПроизв { get; set; }
        public decimal? СуммаРубБезНдс { get; set; }
        public int? СтавкаНдс { get; set; }
        public decimal? СуммаНдс { get; set; }
    }
}
