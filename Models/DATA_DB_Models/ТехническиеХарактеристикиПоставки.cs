using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТехническиеХарактеристикиПоставки
    {
        public int? IdТовара { get; set; }
        public string Описание { get; set; }
        public double? ВысотаМм { get; set; }
        public double? ШиринаМм { get; set; }
        public double? ГлубинаМм { get; set; }
        public double? ВысотаВн { get; set; }
        public double? ШиринаВн { get; set; }
        public double? ГлубинаВн { get; set; }
        public double? ВесБрутто { get; set; }
        public double? ПланНаДень { get; set; }
    }
}
