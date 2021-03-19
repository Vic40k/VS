using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПромУзмк
    {
        public int? Год { get; set; }
        public int? Месяц { get; set; }
        public string НомерКарты { get; set; }
        public string КодВалюты { get; set; }
        public string Сумма { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string НомерСерии { get; set; }
        public string НомерПаспорта { get; set; }
        public string Коммен { get; set; }
        public string Знак { get; set; }
        public int RecordId { get; set; }
        public int? Доступ { get; set; }
        public string СуммаОфиц { get; set; }
        public string СуммаПереч { get; set; }
        public string ОкладОфиц { get; set; }
        public string ВычетыОфиц { get; set; }
        public string ОкладНеофиц { get; set; }
        public string Пн { get; set; }
        public string Премия { get; set; }
        public string ВычетыНеофиц { get; set; }
        public string Доплаты { get; set; }
        public bool? Перечислять { get; set; }
        public decimal? СуммаДол { get; set; }
        public int? ЛичныйНомер { get; set; }
        public string СтарыйНомер { get; set; }
        public decimal? Ставка1с { get; set; }
        public decimal? Премия1с { get; set; }
        public decimal? ВКассу { get; set; }
        public decimal? Отпускные { get; set; }
        public decimal? Ндфл { get; set; }
        public decimal? Фсс { get; set; }
        public decimal? Ффомс { get; set; }
        public decimal? НесчСлучаи { get; set; }
        public decimal? Пфр { get; set; }
        public decimal? Больничные { get; set; }
        public decimal? БольничныеС { get; set; }
        public decimal? ДоплатаЗаОтпускДоплатыЗаНочныеСверхурочныеПраздничные { get; set; }
    }
}
