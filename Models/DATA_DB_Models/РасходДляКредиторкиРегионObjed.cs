using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходДляКредиторкиРегионObjed
    {
        public int НомерПокупателя { get; set; }
        public decimal? СуммаРуб { get; set; }
        public decimal? Сумма { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int Регион { get; set; }
        public decimal? СуммаРубБезНдс { get; set; }
        public int? Idvo { get; set; }
        public byte UsdRu { get; set; }
        public int? Менеджер { get; set; }
    }
}
