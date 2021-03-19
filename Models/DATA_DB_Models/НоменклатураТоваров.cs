﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НоменклатураТоваров
    {
        public int IdТовара { get; set; }
        public string Категория { get; set; }
        public string Наименование { get; set; }
        public string Модель { get; set; }
        public short КоличествоВУпаковке { get; set; }
        public string Примечание { get; set; }
        public string КодТовара { get; set; }
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
        public int IdПодгруппы { get; set; }
        public int? Red { get; set; }
        public int? Yellow { get; set; }
        public int? Stop { get; set; }
        public short? Kanban { get; set; }
        public int Буфер { get; set; }
        public string Штрихкод { get; set; }
        public string НаименованиеBg { get; set; }
        public bool Болгария { get; set; }
        public bool Тула { get; set; }
        public bool Сосенки { get; set; }
        public bool Lb { get; set; }
        public bool? Прайс { get; set; }
        public int? БуферBg { get; set; }
        public string Статус { get; set; }
        public string IdIzd { get; set; }
        public int? IdIzdU { get; set; }
        public string DopKod { get; set; }
        public int? КоличествоВЕдинице { get; set; }
        public string КодBg { get; set; }
        public int? TmpIdent { get; set; }
        public string Замок { get; set; }
        public string КодОкраски { get; set; }
        public string Основной { get; set; }
        public string КодСтраны { get; set; }
        public string Статус2010 { get; set; }
        public decimal Nds { get; set; }
        public int БуферУзмк { get; set; }
        public decimal? КратностьСосенки { get; set; }
        public decimal? КратностьУзмк { get; set; }
        public short УтвержденоКонстр { get; set; }
        public string Ean { get; set; }
        public int? Участок { get; set; }
        public int? IdGr { get; set; }
        public string GroupN { get; set; }
        public string Art { get; set; }
        public decimal? QuantityProducedDay { get; set; }
        public decimal? QuantityProducedDay44 { get; set; }
        public decimal? QuantityProducedDay39 { get; set; }
        public string PrType { get; set; }
        public int? IdPlantType42 { get; set; }
        public int? IdPlantType44 { get; set; }
        public int? IdPlantType39 { get; set; }
        public decimal? Kf { get; set; }
        public int? МинПартия { get; set; }
        public int? ПорогБольшихОтгрузок { get; set; }
        public int? Мжз { get; set; }
        public string НаименованиеУкраинское { get; set; }
        public int? СтатусДоходности { get; set; }
        public int? RedSos { get; set; }
        public int? YellowSos { get; set; }
        public int? StopSos { get; set; }
        public int? OrangeSos { get; set; }
        public int? МощностьUzmk { get; set; }
        public int? МощностьSos { get; set; }
        public DateTime? ДатаЗапуска { get; set; }
        public decimal? КратностьУзмкОбязательная { get; set; }
        public short? ГрупповойРасчет { get; set; }
        public short? Мощность { get; set; }
        public DateTime? ДатаПервогоПрихода { get; set; }
        public DateTime? ДатаМодернизации { get; set; }
        public DateTime? ДатаНовогоОборудования { get; set; }
        public int? КратностьКроватка { get; set; }
    }
}
