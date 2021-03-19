using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходТовара1
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public int ДилерКлиент { get; set; }
        public int НомерПокупателя { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public decimal? ЦенаПродажи { get; set; }
        public decimal? ЦенаПродажиR { get; set; }
        public decimal БазоваяЦена { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public decimal Количество { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int UserId { get; set; }
        public int RecordId { get; set; }
        public decimal Sebestoimost { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public string Основание { get; set; }
        public decimal? КоличествоДляОтгрузки { get; set; }
        public decimal? Ssr { get; set; }
        public decimal? SsrБезНдс { get; set; }
        public short? Префикс { get; set; }
        public int Регион { get; set; }
        public decimal? Nds { get; set; }
        public decimal? Цр { get; set; }
    }
}
