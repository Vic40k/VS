using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходТовараПоставкиOld
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
        public decimal КоличествоКОплатеToDelete { get; set; }
        public decimal КоличествоОплаченноеToDelete { get; set; }
        public decimal КоличествоВСчетеToDelete { get; set; }
        public short? Префикс { get; set; }
        public bool Перенесен { get; set; }
        public decimal? Ssr { get; set; }
        public string ЕдИзм { get; set; }
        public string Валюта { get; set; }
        public int Партия { get; set; }
        public int? ПостРас { get; set; }
        public int НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int Фирма { get; set; }
        public double Кф { get; set; }
        public int Provedeno { get; set; }
        public int FactoryId { get; set; }
        public int IdСкладКуда { get; set; }
        public int? АвтоСписаниеId { get; set; }
        public int? AnalogId { get; set; }
        public int? Who { get; set; }
        public int? IdВходнойЗаявки { get; set; }
        public int? КомплектRecId { get; set; }
        public int? TovDirId { get; set; }
        public int? CodeId { get; set; }
        public int? TypeSpisId { get; set; }
    }
}
