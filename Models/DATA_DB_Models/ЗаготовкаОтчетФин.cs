using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗаготовкаОтчетФин
    {
        public string Наименование { get; set; }
        public string Источник { get; set; }
        public DateTime? ПерваяДата { get; set; }
        public string Password { get; set; }
        public string Фамилия { get; set; }
        public int ФилиалОтч { get; set; }
        public int Номер { get; set; }
    }
}
