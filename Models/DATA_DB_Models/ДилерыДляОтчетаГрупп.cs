using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДилерыДляОтчетаГрупп
    {
        public decimal? СуммаРуб { get; set; }
        public int UserId { get; set; }
        public string Дилер { get; set; }
        public string Юрлицо { get; set; }
        public string Фио { get; set; }
        public decimal? Сумма { get; set; }
        public string Отдел { get; set; }
        public decimal? ОтсрочкаКарточка { get; set; }
        public string Мтк { get; set; }
        public int? Посредник { get; set; }
        public string Город { get; set; }
        public int? Скидка { get; set; }
        public int? IdДилераЦо { get; set; }
        public string Инн { get; set; }
        public int? Кред { get; set; }
        public string Катег { get; set; }
        public string Канал { get; set; }
        public decimal? Оплата12 { get; set; }
        public decimal? Оплата3 { get; set; }
        public int? KolMes { get; set; }
    }
}
