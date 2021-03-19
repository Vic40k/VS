using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class BuxgKorReg
    {
        public string Inn { get; set; }
        public string Поставщик { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int? Префикс { get; set; }
        public string НомерНакл { get; set; }
        public string Наименование { get; set; }
        public double? Количество { get; set; }
        public string Артикул { get; set; }
        public double? Цена { get; set; }
        public double? СуммаБезНалога { get; set; }
        public double? Ндс { get; set; }
        public double? СуммаСНдс { get; set; }
        public int? IdДилера { get; set; }
        public string НомерГтд { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string Договор { get; set; }
        public int? Номер { get; set; }
        public DateTime? Дата { get; set; }
        public int? IdФирмы { get; set; }
        public int? Регион { get; set; }
        public int? UsdRu { get; set; }
        public string SlovaNds { get; set; }
        public int? Валюта { get; set; }
        public string Код { get; set; }
        public string Менеджер { get; set; }
        public DateTime? ДатаКорректы { get; set; }
        public int? UserId { get; set; }
    }
}
