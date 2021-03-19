using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Vedomo
    {
        public int? Номер { get; set; }
        public int? IdДилера { get; set; }
        public int? IdЮрлица { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаДол { get; set; }
        public int UserId { get; set; }
        public int RecordId { get; set; }
        public string Дилер { get; set; }
        public string Юрлицо { get; set; }
        public string Фио { get; set; }
        public string Отдел { get; set; }
        public string Отсрочка { get; set; }
        public string Мтк { get; set; }
        public string Посредник { get; set; }
        public string Город { get; set; }
        public string Скидка { get; set; }
        public string Инн { get; set; }
    }
}
