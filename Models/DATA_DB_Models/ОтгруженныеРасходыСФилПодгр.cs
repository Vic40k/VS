using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтгруженныеРасходыСФилПодгр
    {
        public int? Mes { get; set; }
        public decimal? Ccrub { get; set; }
        public int? God { get; set; }
        public int Регион { get; set; }
        public decimal? OtgrSNds { get; set; }
        public int IdПодгруппы { get; set; }
    }
}
