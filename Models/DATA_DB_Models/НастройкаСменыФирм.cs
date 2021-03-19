using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НастройкаСменыФирм
    {
        public int Id { get; set; }
        public int IdOld { get; set; }
        public int IdCurrent { get; set; }
        public DateTime? DatePrih { get; set; }
        public DateTime? DateVyvoz { get; set; }
        public decimal? KoefOld { get; set; }
        public decimal? KoefCurrent { get; set; }
        public int? BiometricalOut { get; set; }
        public string BiometricalPath { get; set; }
        public string BiometricalFileName { get; set; }
        public int? НдсOld { get; set; }
        public int? Ндс { get; set; }
        public int? IsShowMesBox { get; set; }
    }
}
