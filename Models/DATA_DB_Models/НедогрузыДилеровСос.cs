using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НедогрузыДилеровСос
    {
        public decimal? КоличествоДляОтгрузки { get; set; }
        public decimal? Количество { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
    }
}
