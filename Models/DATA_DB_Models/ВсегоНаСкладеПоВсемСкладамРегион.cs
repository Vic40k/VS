using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВсегоНаСкладеПоВсемСкладамРегион
    {
        public string Склад { get; set; }
        public string Товар { get; set; }
        public string НаимТов { get; set; }
        public decimal? Expr1 { get; set; }
        public decimal? Vputi { get; set; }
        public int Регион { get; set; }
        public decimal ЦенаFob { get; set; }
        public string Категория { get; set; }
        public string КодТовара { get; set; }
        public string Группа { get; set; }
    }
}
