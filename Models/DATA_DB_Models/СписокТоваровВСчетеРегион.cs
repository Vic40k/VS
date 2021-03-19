﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТоваровВСчетеРегион
    {
        public int НомерПокупателя { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public decimal Количество { get; set; }
        public decimal ЦенаПродажи { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public int IdСклада { get; set; }
        public double Объем { get; set; }
        public double Вес { get; set; }
        public DateTime ДатаПредполагаемойПродажи { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal БазоваяЦена { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public DateTime Дата { get; set; }
        public string КодТовара { get; set; }
        public int? GroupOfGoods { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public decimal Цена { get; set; }
        public decimal Sebestoimost { get; set; }
        public string Expr1 { get; set; }
        public int Регион { get; set; }
        public int RecordId { get; set; }
    }
}
