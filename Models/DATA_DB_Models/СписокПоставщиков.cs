using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПоставщиков
    {
        public double? IdПоставщика { get; set; }
        public string КраткоеИмя { get; set; }
        public string Поставщик { get; set; }
        public int? IdПотребителя { get; set; }
        public string Страна { get; set; }
        public string Руководитель { get; set; }
        public string Контакт { get; set; }
        public string Производитель { get; set; }
        public int? IdПредметовЗаказа { get; set; }
        public int? IdУсловийОплаты { get; set; }
        public int? IdВалюты { get; set; }
        public int? IdПеревозчика { get; set; }
        public string СрокИзготовления { get; set; }
        public string МаксВремяЗадержки { get; set; }
        public string БазисПоставки { get; set; }
        public bool? Утвержден { get; set; }
        public string ОбъемВходногоКонтроля { get; set; }
        public DateTime? ДатаПоследнегоАнализа { get; set; }
        public short? ОплатаЗаДней { get; set; }
        public short? СрокТранспортировки { get; set; }
        public bool? Документы { get; set; }
        public int? IdКатегории { get; set; }
        public bool? Действующий { get; set; }
        public string ПротоколУтверждения { get; set; }
        public DateTime? ДатаПротокола { get; set; }
        public string РейтингПоставщика { get; set; }
        public int? IdУсловияХранения { get; set; }
        public int? IdПост { get; set; }
    }
}
