using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспФилТт
    {
        public int Номер { get; set; }
        public int? IdАдреса { get; set; }
        public int Сч { get; set; }
        public byte? ДилерКлиент { get; set; }
        public int? Накладная { get; set; }
        public DateTime? Отгружена { get; set; }
        public int Склад { get; set; }
        public int? UserId { get; set; }
        public string КодЗаказа { get; set; }
        public int? Фирма { get; set; }
        public string Год { get; set; }
        public int? НомерПорядковый { get; set; }
    }
}
