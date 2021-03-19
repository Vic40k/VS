using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокСубсчетов
    {
        public int IdСубсчета { get; set; }
        public string Наименование { get; set; }
        public short? Znak { get; set; }
        public bool? Obekt { get; set; }
        public string Строительство { get; set; }
        public string Завершен { get; set; }
        public string Код { get; set; }
    }
}
