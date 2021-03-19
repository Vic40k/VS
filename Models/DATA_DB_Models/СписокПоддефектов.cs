using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПоддефектов
    {
        public int IdПодкодДефекта { get; set; }
        public string ХарактерПоддефекта { get; set; }
        public int? IdГруппы { get; set; }
        public string КодДефекта { get; set; }
        public string Группа { get; set; }
    }
}
