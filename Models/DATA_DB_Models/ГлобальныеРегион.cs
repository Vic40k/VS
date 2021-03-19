using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ГлобальныеРегион
    {
        public byte Id { get; set; }
        public short? БлокКопия { get; set; }
        public short? БлокНал { get; set; }
        public short? БлокПлатежка { get; set; }
        public short? БлокСчет { get; set; }
        public short? БлокМеньше { get; set; }
        public bool? РаботаетЦентральная { get; set; }
        public DateTime? ВремяЦентральной { get; set; }
        public string ПарольНаИзменениеЦены { get; set; }
        public string ПарольНаИзменениеМенеджера { get; set; }
        public string ПарольНаВыпискуРаспоряжения { get; set; }
        public string ПарольНаИзменениеЗаявки { get; set; }
        public string Наименование { get; set; }
        public string Инн { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string РасСчет { get; set; }
        public string БикКорсчет { get; set; }
        public string Руководитель { get; set; }
        public string Бухгалтер { get; set; }
        public int RecordId { get; set; }
        public decimal? КурсДляТочек { get; set; }
        public int Фирма1ДляРеестра { get; set; }
        public int Фирма2ДляРеестра { get; set; }
        public int СубсчетДляРеестра { get; set; }
        public int Склад { get; set; }
        public DateTime? ДатаПереносаЭд { get; set; }
    }
}
