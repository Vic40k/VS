using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПеревозчиков
    {
        public int IdПеревозчика { get; set; }
        public string Перевозчик { get; set; }
        public string КраткоеИмя { get; set; }
        public string Страна { get; set; }
        public string Контакт { get; set; }
        public int? IdУсловийОплаты { get; set; }
        public bool Утвержден { get; set; }
        public string Рейтинг { get; set; }
        public DateTime? ДатаАнализа { get; set; }
    }
}
