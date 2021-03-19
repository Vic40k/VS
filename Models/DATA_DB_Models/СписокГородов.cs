using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокГородов
    {
        public int IdГорода { get; set; }
        public string Название { get; set; }
        public int IdРегиона { get; set; }
        public float Коэффициент { get; set; }
        public double? НаселениеТысяч { get; set; }
        public string КодГорода { get; set; }
        public byte Страна { get; set; }
    }
}
