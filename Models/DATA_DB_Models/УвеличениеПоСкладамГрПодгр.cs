using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class УвеличениеПоСкладамГрПодгр
    {
        public int? IdСклада { get; set; }
        public decimal? Увеличение { get; set; }
        public int? GrLog { get; set; }
        public decimal? УвГр { get; set; }
        public int? PodGrLog { get; set; }
        public decimal? УвПодгр { get; set; }
    }
}
