using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетРасход1сРегионСос
    {
        public string Inn { get; set; }
        public string Поставщик { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public short? Префикс { get; set; }
        public string Expr1 { get; set; }
        public string Наименование { get; set; }
        public decimal Количество { get; set; }
        public string Артикул { get; set; }
        public double? Цена { get; set; }
        public double? СуммаБезНалога { get; set; }
        public double? Ндс { get; set; }
        public double? СуммаСНдс { get; set; }
        public int IdДилера { get; set; }
        public string НомерГтд { get; set; }
        public string СтранаПроисхождения { get; set; }
        public int? Договор { get; set; }
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public int IdФирмы { get; set; }
        public int Регион { get; set; }
        public byte UsdRu { get; set; }
        public string SlovaNds { get; set; }
        public int Вал { get; set; }
        public string Код { get; set; }
        public string Менеджер { get; set; }
        public int? IdАдреса { get; set; }
        public string Грузополучатель { get; set; }
        public int Склад { get; set; }
        public string Artikul { get; set; }
        public string История { get; set; }
        public int? KlientRegSvoj { get; set; }
        public string Кпп { get; set; }
        public string Expr2 { get; set; }
    }
}
