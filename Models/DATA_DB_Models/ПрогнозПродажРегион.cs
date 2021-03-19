using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПрогнозПродажРегион
    {
        public int IdТовара { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public decimal? ЦенаПередачи { get; set; }
        public decimal? Смпр { get; set; }
        public decimal? Выставка { get; set; }
        public decimal? ОстатокФил { get; set; }
        public int? Месяц { get; set; }
        public decimal? Прогноз1Мес { get; set; }
        public int? Месяц2 { get; set; }
        public decimal? Прогноз2Мес { get; set; }
        public int? Месяц3 { get; set; }
        public decimal? Прогноз3Мес { get; set; }
        public int? Месяц4 { get; set; }
        public decimal? Прогноз4Мес { get; set; }
        public decimal? ВПути { get; set; }
        public int? Год { get; set; }
        public string Завод { get; set; }
        public bool? Утвержден { get; set; }
        public int RecordId { get; set; }
        public int? IdГруппы { get; set; }
        public string КодТовара { get; set; }
        public decimal? ПрогнозНаНеделю { get; set; }
        public int Регион { get; set; }
        public decimal? Отгр1 { get; set; }
        public decimal? Отгр2 { get; set; }
        public decimal? Отгр3 { get; set; }
        public decimal? ВЗаявку { get; set; }
        public int? МесОтг1 { get; set; }
        public int? МесОтг2 { get; set; }
        public int? МесОтг3 { get; set; }
        public string Статус { get; set; }
        public decimal? Подтв { get; set; }
        public decimal? KfРоста { get; set; }
        public decimal? Прогноз1МесПрогноз { get; set; }
    }
}
