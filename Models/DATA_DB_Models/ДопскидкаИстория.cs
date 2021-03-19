using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДопскидкаИстория
    {
        public int IdЗаписи { get; set; }
        public int IdДилера { get; set; }
        public int UserId { get; set; }
        public DateTime Дата { get; set; }
        public string Причина { get; set; }
        public int? Номер { get; set; }
        public decimal? Скидка { get; set; }
        public int? IdПричины { get; set; }
        public int? Тип { get; set; }
    }
}
