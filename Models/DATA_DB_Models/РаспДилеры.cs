using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспДилеры
    {
        public int Номер { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public int? IdАдреса { get; set; }
        public string Название { get; set; }
        public string Наименование { get; set; }
        public int Сч { get; set; }
        public int? ДилерКлиент { get; set; }
        public int? Накладная { get; set; }
        public DateTime? Отгружена { get; set; }
        public int Склад { get; set; }
        public int? UserId { get; set; }
        public int? Префикс { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public byte UsdRu { get; set; }
        public int? Фирма { get; set; }
        public string Год { get; set; }
        public int? НомерПорядковый { get; set; }
        public int Филиал { get; set; }
        public int НомерФилиала { get; set; }
    }
}
