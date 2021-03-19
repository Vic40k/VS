using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗПоложение
    {
        public int Hid { get; set; }
        public decimal Оклад { get; set; }
        public decimal КИнд1 { get; set; }
        public decimal КИнд2 { get; set; }
        public DateTime? ДатаДействияС { get; set; }
        public decimal БонуснаяЧасть { get; set; }
    }
}
