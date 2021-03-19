using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокРаспоряженийДляУдаленияВсеРегион
    {
        public int? Распор { get; set; }
        public int Cчет { get; set; }
        public string Наименование { get; set; }
        public int? Номер { get; set; }
        public byte ДилерКлиент { get; set; }
        public int НомерСчета { get; set; }
        public short? Префикс { get; set; }
        public int Регион { get; set; }
        public string Год { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
    }
}
