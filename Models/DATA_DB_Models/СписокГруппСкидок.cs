using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокГруппСкидок
    {
        public int ГруппаСкидок { get; set; }
        public decimal БазоваяСкидка { get; set; }
        public decimal ОбъемПродажВМесОт { get; set; }
        public decimal ОбъемПродажВМесДо { get; set; }
        public int Отсрочка { get; set; }
        public decimal СкидкаЗаMin { get; set; }
    }
}
