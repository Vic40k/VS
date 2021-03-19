using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Расширенная
    {
        public int IdТовара { get; set; }
        public double ВесБрутто { get; set; }
        public string КодТовара { get; set; }
        public string Категория { get; set; }
        public string Наименование { get; set; }
        public string Модель { get; set; }
        public short КоличествоВУпаковке { get; set; }
        public string Примечание { get; set; }
        public short? ОтрицательноеКолВо { get; set; }
        public double Объем { get; set; }
        public double Вес { get; set; }
        public string Артикул { get; set; }
        public int? GroupOfGoods { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public int? ТипГруппы { get; set; }
        public bool Deleted { get; set; }
        public string Abc { get; set; }
        public double? КоличествоУпаковокВШт { get; set; }
        public string КодТнвд { get; set; }
        public bool Новый { get; set; }
        public string Взломостойкость { get; set; }
        public int? IdНомера { get; set; }
        public string Поставщик { get; set; }
        public double? ВнутреннийОбъем { get; set; }
        public bool КассовоеОтделение { get; set; }
        public bool СменяКода { get; set; }
        public bool ЭлектронныйЗамок { get; set; }
        public short? Ключ { get; set; }
        public bool Код { get; set; }
        public short? КолВоПолок { get; set; }
        public double? ГлубинаВн { get; set; }
        public double? ШиринаВн { get; set; }
        public double? ВысотаВн { get; set; }
        public double? ШиринаМм { get; set; }
        public double? ВысотаМм { get; set; }
        public short? СрокСлужбы { get; set; }
        public short? ГарантийныйСрок { get; set; }
        public string Сертификат { get; set; }
        public string Стандарт { get; set; }
        public string Описание { get; set; }
        public string ОписаниеКода { get; set; }
        public double? ГлубинаМм { get; set; }
        public int? КоличествоБатареек { get; set; }
        public int? Инструкция { get; set; }
        public int? КоличествоБатареекАа { get; set; }
        public bool? Комплектующие { get; set; }
        public double? ПланНаДень { get; set; }
        public int IdПодгруппы { get; set; }
        public string Штрихкод { get; set; }
        public int БуферУзмк { get; set; }
        public int Буфер { get; set; }
        public string Ean { get; set; }
    }
}
