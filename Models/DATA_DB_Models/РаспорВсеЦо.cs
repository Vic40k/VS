using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспорВсеЦо
    {
        public int Распор { get; set; }
        public string КомуОтпустить { get; set; }
        public int Номер { get; set; }
        public int? Cчет { get; set; }
        public int? ДилерКлиент { get; set; }
        public int? НомерСчета { get; set; }
        public int Регион { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int? Преф { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
    }
}
