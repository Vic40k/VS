using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЕдиныеДилеры
    {
        public string Название { get; set; }
        public int Id { get; set; }
        public double? ТовКред { get; set; }
        public short? Отсрочка { get; set; }
        public string Фамилия { get; set; }
        public string Password { get; set; }
        public decimal? СкидкаПлан1 { get; set; }
        public decimal? СкидкаПлан2 { get; set; }
        public int? СкидкаИзКарточки { get; set; }
        public int IdДилОбъединения { get; set; }
        public double ЗаОтсрочку { get; set; }
        public double? Штраф { get; set; }
        public short? Посредник { get; set; }
        public int Регион { get; set; }
        public int RecDl { get; set; }
        public int Менеджер { get; set; }
        public decimal Скидка { get; set; }
        public int? Dostup { get; set; }
    }
}
