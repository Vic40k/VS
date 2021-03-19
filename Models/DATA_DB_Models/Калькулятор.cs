using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Калькулятор
    {
        public int? Сортировка { get; set; }
        public string Категория { get; set; }
        public string Изменение { get; set; }
        public decimal? Процент { get; set; }
    }
}
