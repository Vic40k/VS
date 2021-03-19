using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗаявкиОтДилеровПоставки
    {
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public DateTime? ДатаПодтверждения { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public int IdДилера { get; set; }
        public int IdВалюты { get; set; }
        public byte УсловияПоставки { get; set; }
        public int UserId { get; set; }
        public bool ВыписаноРаспоряжение { get; set; }
        public int IdСклада { get; set; }
        public int Оплачена { get; set; }
        public bool Аннулирована { get; set; }
        public decimal? Total { get; set; }
        public decimal? Объем { get; set; }
        public int? Вес { get; set; }
        public short? Отсрочка { get; set; }
        public bool? ВидОплаты { get; set; }
        public DateTime? ДатаСчетФактуры { get; set; }
        public int IdФирмы { get; set; }
        public int? Грузоотправитель { get; set; }
        public decimal? Курс { get; set; }
        public string Ответственные { get; set; }
        public int? IdПеревозчика { get; set; }
        public string НомерНакладной { get; set; }
        public string НомерСф { get; set; }
        public bool Provedeno { get; set; }
        public int? IdОперации { get; set; }
        public int? IdЮрЛица { get; set; }
        public int СтатусЗаказа { get; set; }
        public string НомерПечатный { get; set; }
        public string Description { get; set; }
        public string InsideNbr { get; set; }
        public int? Manager { get; set; }
        public int FactoryId { get; set; }
        public int? ФирмаПлательщик { get; set; }
        public int? CreaterId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LastEditId { get; set; }
        public DateTime? LastEditDate { get; set; }
        public int? CurrentEditUserId { get; set; }
        public byte Оприходование { get; set; }
        public int? ChildNbr { get; set; }
        public int? ParentNbr { get; set; }
        public int? DefSklad { get; set; }
        public int? Shema { get; set; }
        public int? Year { get; set; }
        public int? Number { get; set; }
        public int? Proizvodstvo { get; set; }
    }
}
