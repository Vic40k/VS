using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СоответсвиеСубсчетСтатья
    {
        public int Код { get; set; }
        public string Субсчет { get; set; }
        public short? Статья { get; set; }
        public int? Приход { get; set; }
    }
}
