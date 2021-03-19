using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstАвтоЗаявкиПоРеализации
    {
        public int Требование { get; set; }
        public int Заявка { get; set; }
        public DateTime Дата { get; set; }
        public int СкладОткуда { get; set; }
        public int СкладКуда { get; set; }
        public int ФирмаОткуда { get; set; }
        public int ФирмаКуда { get; set; }
        public int UserId { get; set; }
        public int FactoryId { get; set; }
    }
}
