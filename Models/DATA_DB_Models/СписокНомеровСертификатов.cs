using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокНомеровСертификатов
    {
        public int IdНомера { get; set; }
        public string Наименование { get; set; }
        public string Номер1 { get; set; }
        public string Номер2 { get; set; }
        public string Номер3 { get; set; }
        public DateTime? Дата { get; set; }
        public DateTime? ДействителенДо { get; set; }
    }
}
