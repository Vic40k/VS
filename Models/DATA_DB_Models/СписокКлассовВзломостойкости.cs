using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКлассовВзломостойкости
    {
        public int IdСертификата { get; set; }
        public string Сертификат { get; set; }
        public string Примечание { get; set; }
    }
}
