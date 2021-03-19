using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДляВебПогрузочного
    {
        public int? Rec { get; set; }
        public string Art { get; set; }
        public string Tov { get; set; }
        public decimal? Kol { get; set; }
        public double? Ves { get; set; }
        public string Mod { get; set; }
        public double? Ob { get; set; }
        public int? Zak { get; set; }
        public int НомерПокупателя { get; set; }
        public int Регион { get; set; }
        public string Priorit { get; set; }
        public int IdТовара { get; set; }
        public string ПаллетаНомер { get; set; }
        public int ЗаводСклад { get; set; }
        public string PrimPogr { get; set; }
    }
}
