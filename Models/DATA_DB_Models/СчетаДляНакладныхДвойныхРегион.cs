using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СчетаДляНакладныхДвойныхРегион
    {
        public string Наименование { get; set; }
        public int НомерСчета { get; set; }
        public DateTime Дата { get; set; }
        public bool Оплачена { get; set; }
        public int Номер { get; set; }
        public string Накладная { get; set; }
        public int IdФирмы { get; set; }
        public bool ВидОплаты { get; set; }
        public int Регион { get; set; }
        public int? Секретно { get; set; }
        public byte UsdRu { get; set; }
        public string КомуОтпустить { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public DateTime? ДоверенностьДата { get; set; }
    }
}
