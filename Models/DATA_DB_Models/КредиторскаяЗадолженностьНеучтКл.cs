using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КредиторскаяЗадолженностьНеучтКл
    {
        public int? Id { get; set; }
        public int? UsdRu { get; set; }
        public int LastUserId { get; set; }
        public decimal? СуммаОпл { get; set; }
        public DateTime? ДатаПр { get; set; }
    }
}
