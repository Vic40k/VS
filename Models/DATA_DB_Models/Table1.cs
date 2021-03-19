using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Table1
    {
        public int RecordId { get; set; }
        public string НомерСертификата { get; set; }
        public DateTime? ДатаСертификата { get; set; }
        public int? КтоВнес { get; set; }
        public DateTime? ДатаРегистрации { get; set; }
        public string IdМодели { get; set; }
        public int IdКатегории { get; set; }
    }
}
