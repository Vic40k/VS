using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокНакладныхПоставки
    {
        public int IdСклада { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public short? Префикс { get; set; }
        public string Год { get; set; }
        public int НомерПорядковый { get; set; }
        public int Фирма { get; set; }
        public string ФирмаНаз { get; set; }
        public string Участок { get; set; }
        public string Склад { get; set; }
        public int? Provedeno { get; set; }
        public int FactoryId { get; set; }
    }
}
