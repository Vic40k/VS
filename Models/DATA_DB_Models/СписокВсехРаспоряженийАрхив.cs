using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокВсехРаспоряженийАрхив
    {
        public int Распор { get; set; }
        public int? Cчет { get; set; }
        public string Название { get; set; }
        public int? ДилерКлиент { get; set; }
        public int? Idfirm { get; set; }
        public int ВидОплаты { get; set; }
        public int? НомерСчета { get; set; }
        public int UsdRu { get; set; }
        public int IdДилера { get; set; }
        public DateTime? Дата { get; set; }
        public int? Префикс { get; set; }
        public DateTime? Отгружена { get; set; }
        public string Стадия { get; set; }
        public string Водитель { get; set; }
    }
}
