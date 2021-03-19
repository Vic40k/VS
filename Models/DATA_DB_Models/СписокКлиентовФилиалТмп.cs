using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКлиентовФилиалТмп
    {
        public string Наименование { get; set; }
        public string Индекс { get; set; }
        public string Города { get; set; }
        public string УлицаДом { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public string Inn { get; set; }
        public string Телефоны { get; set; }
        public string Руководитель { get; set; }
        public string История { get; set; }
        public bool? Дилер { get; set; }
    }
}
