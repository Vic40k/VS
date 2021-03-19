using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НачалоРегион
    {
        public string Артикул { get; set; }
        public decimal? Филиал { get; set; }
        public decimal? Выставка { get; set; }
        public int? Склад { get; set; }
        public decimal? ФилиалДол { get; set; }
        public decimal? ВыставкаДол { get; set; }
        public decimal? ФилиалРуб { get; set; }
        public decimal? ВыставкаРуб { get; set; }
    }
}
