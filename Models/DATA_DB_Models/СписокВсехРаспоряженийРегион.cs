using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокВсехРаспоряженийРегион
    {
        public int? Распор { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public int Cчет { get; set; }
        public string КомуОтпустить { get; set; }
        public int ДилерКлиент { get; set; }
        public int НомерСчета { get; set; }
        public int IdФирмы { get; set; }
        public bool ВидОплаты { get; set; }
        public byte UsdRu { get; set; }
        public int? Учтена { get; set; }
        public string Наименование { get; set; }
        public string Примечание { get; set; }
        public int? Префикс { get; set; }
        public string НомерТт { get; set; }
        public string НомерНакл { get; set; }
        public int Регион { get; set; }
        public int? Секретно { get; set; }
        public double? Сумма { get; set; }
        public double? Вес { get; set; }
        public int? КолСтрок { get; set; }
        public double? Объем { get; set; }
        public string Стадия { get; set; }
        public string Водитель { get; set; }
        public short? Доставка { get; set; }
        public int? IdСтадииРасп { get; set; }
        public int? IdВодителяРасп { get; set; }
        public int? IdПунктаРасп { get; set; }
        public int? IdПеревозчикаРасп { get; set; }
        public int? IdЗаказчикаТранспортаРасп { get; set; }
        public int? IdПричины { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public DateTime? ДоверенностьДата { get; set; }
        public DateTime? Отгружена { get; set; }
        public string Название { get; set; }
        public int? ДилКл { get; set; }
        public string НаименованиеГруза { get; set; }
        public int СамовывозИзМосквы { get; set; }
        public double? Штраф { get; set; }
        public int? KlientReg { get; set; }
    }
}
