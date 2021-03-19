using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходДляФилиалаПерекачка
    {
        public string Артикул { get; set; }
        public decimal Количество { get; set; }
        public int Номер { get; set; }
        public string Наименование { get; set; }
        public decimal Sebestoimost { get; set; }
        public string НомерГтд { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public byte UsdRu { get; set; }
        public decimal? Ssr { get; set; }
        public string Документ { get; set; }
        public int? UserId { get; set; }
        public DateTime? ДатаПрихода { get; set; }
    }
}
