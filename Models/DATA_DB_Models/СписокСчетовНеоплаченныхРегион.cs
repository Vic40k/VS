using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокСчетовНеоплаченныхРегион
    {
        public int Выражение1 { get; set; }
        public DateTime Дата { get; set; }
        public int IdКлиента { get; set; }
        public int Номер { get; set; }
        public int Склад { get; set; }
        public decimal? Сумма { get; set; }
        public string Наименование { get; set; }
        public string Фамилия { get; set; }
        public bool ВыписаноРаспоряжение { get; set; }
        public bool Оплачена { get; set; }
        public int Регион { get; set; }
        public int? KlientRegSvoj { get; set; }
    }
}
