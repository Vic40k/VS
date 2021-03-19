using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗПоложениеОценки
    {
        public int Hid { get; set; }
        public string Оценка { get; set; }
        public decimal Вес { get; set; }
        public string Ответственный { get; set; }
        public int RecordId { get; set; }
        public string Фио { get; set; }
    }
}
