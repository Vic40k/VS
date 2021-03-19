using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПривязкаПриОплате
    {
        public string Фирма { get; set; }
        public short? ДилерКлиент { get; set; }
        public int? IdФирмыТо { get; set; }
        public int IdФирмы { get; set; }
        public string ФирмаПлат { get; set; }
        public string Наименование { get; set; }
    }
}
