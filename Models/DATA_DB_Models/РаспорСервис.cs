using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспорСервис
    {
        public int Номер { get; set; }
        public int? НомерСчета { get; set; }
        public int? IdСтадии { get; set; }
        public decimal? Затраты { get; set; }
        public string Водитель { get; set; }
        public int? IdВодителя { get; set; }
        public int? IdПункта { get; set; }
        public int? ДилерКлиент { get; set; }
        public int? Префикс { get; set; }
        public int? Причина { get; set; }
        public int? Год { get; set; }
        public int? НомерПорядковый { get; set; }
    }
}
