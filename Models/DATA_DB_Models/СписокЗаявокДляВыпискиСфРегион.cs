using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЗаявокДляВыпискиСфРегион
    {
        public string Наименование { get; set; }
        public int НомерСчета { get; set; }
        public DateTime Дата { get; set; }
        public bool ВидОплаты { get; set; }
        public int IdФирмы { get; set; }
        public int IdГорода { get; set; }
        public string УлицаДом { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public string Inn { get; set; }
        public string Телефоны { get; set; }
        public bool? Учтена { get; set; }
        public short? Префикс { get; set; }
        public bool ВыписанаСчетФактура { get; set; }
        public int Регион { get; set; }
        public int Expr1 { get; set; }
    }
}
