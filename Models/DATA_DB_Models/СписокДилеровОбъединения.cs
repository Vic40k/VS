using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДилеровОбъединения
    {
        public int IdОбъединения { get; set; }
        public string Объединение { get; set; }
        public int IdДилераЦо { get; set; }
        public int РегионЦо { get; set; }
        public int? Мтк { get; set; }
        public int? IdКаналаСбытаОб { get; set; }
        public int? IdКатегорииОб { get; set; }
        public short? ПосредникОб { get; set; }
        public decimal СкидкаОб { get; set; }
        public short? ОтсрочкаОб { get; set; }
    }
}
