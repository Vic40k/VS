using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstАртикулыКлиентов
    {
        public long RecId { get; set; }
        public long IdTmc { get; set; }
        public int Поставщик { get; set; }
        public string Наименование { get; set; }
        public string АртикулКлиента { get; set; }
    }
}
