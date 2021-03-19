using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляПереводРегион
    {
        public int Номер { get; set; }
        public int НомерЗаявки { get; set; }
        public string Наименование { get; set; }
        public DateTime Дата { get; set; }
        public int Склад { get; set; }
        public bool Распоряжение { get; set; }
        public bool Оплачена { get; set; }
        public int IdСклада { get; set; }
        public int? Наклад { get; set; }
        public string Откуда { get; set; }
        public bool ВидОплаты { get; set; }
        public string КодМагазина { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public DateTime? ДоверенностьДата { get; set; }
        public DateTime? Отгружена { get; set; }
        public int Регион { get; set; }
        public int ОтКого { get; set; }
    }
}
