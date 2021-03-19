using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НедогрузыДилеров
    {
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
        public int НомерПокупателя { get; set; }
        public decimal? КоличествоДляОтгрузки { get; set; }
        public decimal? Количество { get; set; }
        public int IdДилера { get; set; }
        public string КодЗаказа { get; set; }
        public string Название { get; set; }
        public string Фамилия { get; set; }
        public byte ДилерКлиент { get; set; }
        public decimal? ЦенаПродажи { get; set; }
        public decimal? ЦенаПродажиR { get; set; }
        public decimal? БазоваяЦена { get; set; }
        public decimal? БазоваяЦенаR { get; set; }
        public DateTime? ДатаПредполагаемойПродажи { get; set; }
        public int? UserId { get; set; }
        public decimal? Sebestoimost { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public decimal? Ssr { get; set; }
        public decimal? Nds { get; set; }
        public decimal? Цр { get; set; }
        public decimal? БазоваяЦенаRДоДоп { get; set; }
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public byte UsdRu { get; set; }
        public bool Оплачена { get; set; }
        public bool ВидОплаты { get; set; }
        public int UserIdZ { get; set; }
        public int Склад { get; set; }
        public int? Накладная { get; set; }
        public int Секретно { get; set; }
        public int? IdФирмы { get; set; }
        public decimal? SsrБезНдс { get; set; }
        public int? RecordРекламация { get; set; }
        public DateTime? ДатаРасчетная { get; set; }
        public int? Подтверждение { get; set; }
        public DateTime? ДатаПлановая { get; set; }
    }
}
