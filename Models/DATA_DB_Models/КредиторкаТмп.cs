using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КредиторкаТмп
    {
        public int? UserId { get; set; }
        public decimal? Курс { get; set; }
        public DateTime? Дата { get; set; }
        public DateTime? ДатаОдОтчетГруппы { get; set; }
        public DateTime? ДатаДоОтчетГруппы { get; set; }
        public int? IdДилера { get; set; }
        public int? IdГруппы { get; set; }
        public int? IdПодгруппы { get; set; }
        public int? IdТовара { get; set; }
        public int? IdКанала { get; set; }
        public string Отдел { get; set; }
    }
}
