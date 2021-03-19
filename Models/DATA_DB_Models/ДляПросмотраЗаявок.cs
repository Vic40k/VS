﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДляПросмотраЗаявок
    {
        public int Номер { get; set; }
        public string Expr1 { get; set; }
        public string Наименование { get; set; }
        public DateTime Дата { get; set; }
        public decimal? Сумма { get; set; }
        public bool Распоряжение { get; set; }
        public bool Оплачена { get; set; }
        public int? Id { get; set; }
        public string Фирма { get; set; }
        public int Склад { get; set; }
        public int Менеджер { get; set; }
        public int? Накладная { get; set; }
        public DateTime? Отгружена { get; set; }
        public bool УсловияПоставки { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string Маршрут { get; set; }
        public string Стадия { get; set; }
        public string Водитель { get; set; }
        public string НомерНакл { get; set; }
        public int Филиал { get; set; }
        public int НомерФилиала { get; set; }
    }
}
