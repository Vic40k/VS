using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокСтатейРасхода
    {
        public int IdСтатьи { get; set; }
        public string Наименование { get; set; }
        public string Код { get; set; }
        public short? Znak { get; set; }
        public string Слагаемые { get; set; }
        public string НаименованиеBlg { get; set; }
        public int Блок { get; set; }
        public int Группа { get; set; }
        public int Подгруппа { get; set; }
        public int ПрямыеКосвенные { get; set; }
        public int ПостоянныеПеременные { get; set; }
    }
}
