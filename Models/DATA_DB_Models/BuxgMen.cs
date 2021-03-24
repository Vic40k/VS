﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class BuxgMen
    {
        public string Inn { get; set; }
        public string Поставщик { get; set; }
        public DateTime? Дата { get; set; }
        public string КодГорода { get; set; }
        public string НомерСо { get; set; }
        public DateTime? ДатаСо { get; set; }
        public int? НомерПорядковый { get; set; }
        public string КодГорода1 { get; set; }
        public int? Накладная { get; set; }
        public string Наименование { get; set; }
        public double? Количество { get; set; }
        public string Артикул { get; set; }
        public double? Цена { get; set; }
        public double? СуммаБезНалога { get; set; }
        public double? Ндс { get; set; }
        public double? СуммаСНдс { get; set; }
        public string Код { get; set; }
        public int? Idvo { get; set; }
        public int? Префикс { get; set; }
        public int? НомерСф { get; set; }
        public string НомерГтд { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string Договор { get; set; }
        public int? IdСклада { get; set; }
        public int? КодСклада { get; set; }
        public string Склад { get; set; }
        public int? НомерПорядковый1 { get; set; }
        public string Группа { get; set; }
        public double? Вес { get; set; }
        public int? GroupOfGoods { get; set; }
        public int? Регион { get; set; }
        public int? UserId { get; set; }
    }
}