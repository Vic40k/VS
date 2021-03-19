using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СчетаКлиентыСНеоплаченнымиРегион
    {
        public string Наименование { get; set; }
        public DateTime Дата { get; set; }
        public int Номер { get; set; }
        public bool Оплачена { get; set; }
        public DateTime? ДатаПредполагаемойПродажи { get; set; }
        public int Склад { get; set; }
        public string Фирма { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public bool? Учтена { get; set; }
        public bool ВидОплаты { get; set; }
        public int? Регион { get; set; }
    }
}
