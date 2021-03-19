using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПодписиЗаНал
    {
        public int IdСотрудника { get; set; }
        public int Месяц { get; set; }
        public int Год { get; set; }
        public byte[] Подпись { get; set; }
        public string Фам { get; set; }
        public string Имя { get; set; }
        public string Отч { get; set; }
        public decimal? СуммаДол { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаОфиц { get; set; }
        public decimal? ВычетыНеофиц { get; set; }
        public decimal? СуммаПереч { get; set; }
        public decimal? ВычетыОфиц { get; set; }
        public int? CardId { get; set; }
        public int? ЕстьПодпись { get; set; }
        public DateTime? ДатаПодписи { get; set; }
    }
}
