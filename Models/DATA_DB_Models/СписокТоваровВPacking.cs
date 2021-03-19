using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТоваровВPacking
    {
        public int? Номер { get; set; }
        public string Адрес { get; set; }
        public string Грузополучатель { get; set; }
        public string АдресГр { get; set; }
        public int Num { get; set; }
        public string КодТнвд { get; set; }
        public string ОписаниеКода { get; set; }
        public string Валюта { get; set; }
        public DateTime Дата { get; set; }
        public int? НомерСчета { get; set; }
        public string КомуОтпустить { get; set; }
        public string Контракт { get; set; }
        public string Наименование1 { get; set; }
        public DateTime? Срок { get; set; }
        public bool Оплачена { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public byte ДилерКлиент { get; set; }
        public string Модель { get; set; }
        public decimal? Количество { get; set; }
        public string КодТовара { get; set; }
        public string Примечание { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string УпаковкаНомер { get; set; }
        public string Склад { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Expr1 { get; set; }
        public string Товар { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public string КодЗаказа { get; set; }
        public int IdДилера { get; set; }
        public int? Категория { get; set; }
        public string УсловияПоставкиType { get; set; }
        public string Expr2 { get; set; }
        public double? Вес { get; set; }
        public double? ВесБрутто { get; set; }
        public string Expr3 { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int RecordId { get; set; }
        public string Фил { get; set; }
        public string Юрлицо { get; set; }
        public int? КоличествоВЕдинице { get; set; }
        public short? КоличествоВУпаковке { get; set; }
        public int? ФактМест { get; set; }
        public string ПунктРазгрузки { get; set; }
    }
}
