using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетДилерыУслуги11111
    {
        public byte UsdRu { get; set; }
        public int IdДилера { get; set; }
        public string КодЗаказа { get; set; }
        public string Поставщик { get; set; }
        public DateTime? Дата { get; set; }
        public int? Накладная { get; set; }
        public short? Префикс { get; set; }
        public string Наименование { get; set; }
        public decimal? Количество { get; set; }
        public string Артикул { get; set; }
        public int Филиал { get; set; }
        public string Инн { get; set; }
        public string Юрлицо { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public int Номер { get; set; }
        public int? IdЮрлица { get; set; }
        public int? Expr1 { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string НомерНакл { get; set; }
        public int НомерПокупателя { get; set; }
        public int RecordId { get; set; }
    }
}
