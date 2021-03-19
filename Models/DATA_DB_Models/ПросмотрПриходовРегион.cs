using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПросмотрПриходовРегион
    {
        public string Документ { get; set; }
        public DateTime ДатаПрихода { get; set; }
        public string Склад { get; set; }
        public int Партия { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public decimal Sebestoimost { get; set; }
        public decimal КолВо { get; set; }
        public string Поставщик { get; set; }
        public string НаименованиеОперации { get; set; }
        public string Ордер { get; set; }
        public decimal? IdФирмы { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public string НомерГтд { get; set; }
        public double? Объем { get; set; }
        public double Вес { get; set; }
        public string СтранаПроисхождения { get; set; }
        public decimal Цена { get; set; }
        public decimal Ssr { get; set; }
        public int RecordId { get; set; }
        public int? RecordРекламация { get; set; }
        public DateTime Expr1 { get; set; }
        public int Регион { get; set; }
        public string КодТовара { get; set; }
        public string Ном { get; set; }
        public short? Оценка1 { get; set; }
        public short? Оценка2 { get; set; }
        public short? Оценка3 { get; set; }
        public short? Оценка4 { get; set; }
        public short? Оценка5 { get; set; }
        public short? Оценка6 { get; set; }
        public short? Оценка7 { get; set; }
        public short? Оценка8 { get; set; }
        public short? Оценка9 { get; set; }
        public int? НомерРекламации { get; set; }
        public int ЗаводСклад { get; set; }
        public string Кто { get; set; }
    }
}
