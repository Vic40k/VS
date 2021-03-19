using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КредиторскаяЗадолженностьКлОб
    {
        public int Id { get; set; }
        public int? IdЮрлица { get; set; }
        public int? UsdRu { get; set; }
        public int Номер { get; set; }
        public int UserId { get; set; }
        public decimal? СуммаДоллары { get; set; }
        public int? Накладная { get; set; }
        public decimal? СуммаОплатыR { get; set; }
    }
}
