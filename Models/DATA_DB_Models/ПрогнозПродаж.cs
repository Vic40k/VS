using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПрогнозПродаж
    {
        public int IdТовара { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public decimal? ЦенаПередачи { get; set; }
        public decimal? Смпр { get; set; }
        public decimal? ОстатокГлСклад { get; set; }
        public decimal? ОстатокФил { get; set; }
        public int? Месяц { get; set; }
        public decimal? Прогноз1Мес { get; set; }
        public int? Месяц2 { get; set; }
        public decimal? Прогноз2Мес11 { get; set; }
        public int? Месяц3 { get; set; }
        public decimal? Прогноз3Мес11 { get; set; }
        public int? Месяц4 { get; set; }
        public decimal? Прогноз4Мес11 { get; set; }
        public decimal? ВозможноеОткл { get; set; }
        public int? Год { get; set; }
        public string Завод { get; set; }
        public bool? Утвержден { get; set; }
        public int RecordId { get; set; }
        public int? IdГруппы { get; set; }
        public string КодТовара { get; set; }
        public string Det { get; set; }
        public bool? Flag { get; set; }
        public string Pack { get; set; }
        public decimal? ПрогнозНаНеделю { get; set; }
        public decimal? ПрогнозЧерезНеделю { get; set; }
        public int? Месяц0 { get; set; }
        public decimal? Прогноз0Мес { get; set; }
        public decimal? Прогноз1МесПрогноз { get; set; }
        public decimal? Прогноз2МесПрогноз11 { get; set; }
        public decimal? Прогноз3МесПрогноз11 { get; set; }
    }
}
