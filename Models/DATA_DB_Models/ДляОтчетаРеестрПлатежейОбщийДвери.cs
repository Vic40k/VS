using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДляОтчетаРеестрПлатежейОбщийДвери
    {
        public string Статус { get; set; }
        public int? IdПодразделения { get; set; }
        public string Подр { get; set; }
        public string НомерСчета { get; set; }
        public DateTime? ДатаСчета { get; set; }
        public string Фирма { get; set; }
        public decimal? СуммаОплатыВал { get; set; }
        public string Валюта { get; set; }
        public string Поставщик { get; set; }
        public int IdReestra { get; set; }
        public decimal? СуммаВал { get; set; }
        public string Статья { get; set; }
        public DateTime? Дата { get; set; }
        public DateTime? ДатаОплаты { get; set; }
        public string Код { get; set; }
        public string Комментарий { get; set; }
        public string Структура { get; set; }
        public int IdRecord { get; set; }
        public string НаименованиеBlg { get; set; }
        public int? IdФирмы { get; set; }
        public short? Znak { get; set; }
        public bool? Usd { get; set; }
        public decimal? СуммаРубБезНдс { get; set; }
        public decimal? СуммаНдс { get; set; }
        public string Субсчет { get; set; }
    }
}
