using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокОбщихСтатей
    {
        public int IdСтатьи { get; set; }
        public string Наименование { get; set; }
        public string Код { get; set; }
        public int IdСубсчета { get; set; }
        public string Тип { get; set; }
        public int? IdПодразделения { get; set; }
    }
}
