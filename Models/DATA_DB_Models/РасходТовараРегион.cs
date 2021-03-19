using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходТовараРегион
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public byte ДилерКлиент { get; set; }
        public int НомерПокупателя { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public decimal ЦенаПродажи { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public decimal БазоваяЦена { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public decimal Количество { get; set; }
        public DateTime ДатаПредполагаемойПродажи { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int UserId { get; set; }
        public int RecordId { get; set; }
        public decimal Sebestoimost { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public string Основание { get; set; }
        public string Накладная { get; set; }
        public decimal КоличествоКОплате { get; set; }
        public decimal КоличествоОплаченное { get; set; }
        public decimal КоличествоВСчете { get; set; }
        public decimal? КоличествоВНалоговой { get; set; }
        public short? Префикс { get; set; }
        public bool Перенесен { get; set; }
        public decimal Ssr { get; set; }
        public int Регион { get; set; }
        public int? RecordIdOld { get; set; }
        public string УпаковкаНомер { get; set; }
        public int? НомерОфиса { get; set; }
        public decimal? Цр { get; set; }
        public decimal? Nds { get; set; }
        public int? НомерЗаказа { get; set; }
        public int? РегионЗаказа { get; set; }
        public int? НомерЗак { get; set; }
        public int? РегионЗак { get; set; }
        public decimal БазоваяЦенаRДоДоп { get; set; }
        public int? RecordРекламация { get; set; }
        public decimal? SsrБезНдс { get; set; }
        public DateTime? ДатаРасчетная { get; set; }
        public int? Подтверждение { get; set; }
        public decimal? План { get; set; }
        public string ПаллетаНомер { get; set; }
        public int? Причина { get; set; }
        public string КодЗаказа { get; set; }
        public int? НомерКоректы { get; set; }
        public string ПричинаПодробно { get; set; }
        public int? RecVosst { get; set; }
    }
}
