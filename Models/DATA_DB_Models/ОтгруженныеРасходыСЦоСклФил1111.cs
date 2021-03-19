using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгруженныеРасходыСЦоСклФил1111
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public decimal? КолОтг { get; set; }
        public decimal? Сс { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public decimal? Ccrub { get; set; }
    }
}
