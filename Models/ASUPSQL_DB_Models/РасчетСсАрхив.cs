using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class РасчетСсАрхив
    {
        public int Id { get; set; }
        public int IdИзделия { get; set; }
        public DateTime ДатаФормирования { get; set; }
        public int Раздел { get; set; }
        public int IdТовара { get; set; }
        public string Деталь { get; set; }
        public string ЕдИзм { get; set; }
        public decimal? Цена { get; set; }
        public double? IdВалюты { get; set; }
        public decimal? НормаРасхода { get; set; }
        public decimal? Вес { get; set; }
        public byte? Площадка { get; set; }
        public decimal? ИтогоРуб { get; set; }
        public decimal? Ким { get; set; }
        public decimal? КурсUsd { get; set; }
        public decimal? КурсEuro { get; set; }
        public string ЗаголовокРаздела { get; set; }
        public decimal? Ндс { get; set; }
        public string МетодLifo { get; set; }
        public string СНдс { get; set; }
        public decimal? Кдр { get; set; }
        public short ТипРасчета { get; set; }
        public string Кто { get; set; }
        public decimal? Количество { get; set; }
        public string Примечание { get; set; }
        public decimal? НормаВыработкиПоCell { get; set; }
        public decimal? ЦенаСправочник { get; set; }
        public string МетодКосвенных { get; set; }
        public string ПримечаниеКПрайсу { get; set; }
        public short? МетодЗп { get; set; }
    }
}
