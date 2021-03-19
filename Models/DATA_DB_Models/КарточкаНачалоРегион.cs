using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КарточкаНачалоРегион
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public string ДатаЗаписи { get; set; }
        public decimal Поступило { get; set; }
        public string Накладной { get; set; }
        public string Наименование { get; set; }
        public string Поставщик { get; set; }
        public string Дата { get; set; }
        public int RecordId { get; set; }
        public int Регион { get; set; }
        public int UserId { get; set; }
        public int RecordРекламации { get; set; }
    }
}
