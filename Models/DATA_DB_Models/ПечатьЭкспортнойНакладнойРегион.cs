using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПечатьЭкспортнойНакладнойРегион
    {
        public string Наименование { get; set; }
        public string Грузоп { get; set; }
        public string Юрлицо { get; set; }
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public string УсловияПоставкиType { get; set; }
        public string Адрес { get; set; }
        public decimal Количество { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public double? IdВалюты { get; set; }
        public decimal? ЦенаПродажи { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public decimal Цена { get; set; }
        public double Вес { get; set; }
        public double? ВесБрутто { get; set; }
        public double? КоличествоУпаковокВШт { get; set; }
        public string КодТнвд { get; set; }
        public string ОписаниеКода { get; set; }
        public string Валюта { get; set; }
        public string АдресГр { get; set; }
        public string Контракт { get; set; }
        public string УпаковкаНомер { get; set; }
        public string КодЗаказа { get; set; }
        public string Груполучатель { get; set; }
        public string Примечание { get; set; }
        public byte Expr2 { get; set; }
        public string Фирма { get; set; }
        public string БанкРекв { get; set; }
        public string ВБанке { get; set; }
        public string АдресСклада { get; set; }
        public string Руководитель { get; set; }
        public string ГлБух { get; set; }
        public string Expr1 { get; set; }
        public decimal? Курс { get; set; }
    }
}
