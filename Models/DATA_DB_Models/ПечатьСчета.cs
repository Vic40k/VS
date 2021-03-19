using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПечатьСчета
    {
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public string Юрлицо { get; set; }
        public string Адрес { get; set; }
        public string Телефоны { get; set; }
        public string Примечание { get; set; }
        public string Артикул { get; set; }
        public string Товар { get; set; }
        public decimal Количество { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public int UserId { get; set; }
        public int? Id { get; set; }
        public double? Объем { get; set; }
        public double? Вес { get; set; }
        public string КодГорода { get; set; }
        public decimal? Nds { get; set; }
        public decimal БазоваяЦенаRДоДоп { get; set; }
        public int Секретно { get; set; }
        public byte UsdRu { get; set; }
        public int? Рс { get; set; }
        public int IdТовара { get; set; }
        public string БанкРекв { get; set; }
        public string ВБанке { get; set; }
        public string Бик { get; set; }
    }
}
