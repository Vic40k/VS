using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДилерыМосквы
    {
        public string Название { get; set; }
        public short? Отсрочка { get; set; }
        public double? МаксимальныйКредитR { get; set; }
        public int IdДилОбъединения { get; set; }
        public int Id { get; set; }
        public string Категория { get; set; }
        public string Кратко { get; set; }
    }
}
