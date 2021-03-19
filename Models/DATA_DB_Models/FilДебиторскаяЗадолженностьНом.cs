using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class FilДебиторскаяЗадолженностьНом
    {
        public int НомерПокупателя { get; set; }
        public int? IdДилера { get; set; }
        public decimal? SumСумма { get; set; }
        public decimal? SumСуммаРуб { get; set; }
        public int? Менеджер { get; set; }
        public int Userid { get; set; }
        public int? Регион { get; set; }
        public bool? Оплачена { get; set; }
        public DateTime? Отгружена { get; set; }
        public int? IdФирмы { get; set; }
        public int? Отсрочка { get; set; }
        public string Дилер { get; set; }
        public string Юрлицо { get; set; }
        public string Фио { get; set; }
        public string Отдел { get; set; }
        public decimal? ОтсрочкаКарточка { get; set; }
        public string Мтк { get; set; }
        public int? Посредник { get; set; }
        public string Город { get; set; }
        public int? Скидка { get; set; }
        public int? ОтсрочкаПродленная { get; set; }
        public int? IdДилераЦо { get; set; }
        public string Инн { get; set; }
        public string Категория { get; set; }
        public string Канал { get; set; }
        public int RecordId { get; set; }
        public decimal? Оплата12 { get; set; }
        public decimal? Оплата3 { get; set; }
        public int? KolMes { get; set; }
    }
}
