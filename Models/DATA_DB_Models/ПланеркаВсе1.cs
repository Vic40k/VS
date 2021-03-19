using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПланеркаВсе1
    {
        public string Группа { get; set; }
        public decimal? План { get; set; }
        public int? Неделя { get; set; }
        public string Филиал { get; set; }
        public string Фамилия { get; set; }
        public int Номер { get; set; }
        public decimal? Забронировано { get; set; }
        public string Товар { get; set; }
        public decimal? Kf { get; set; }
        public int RecordId { get; set; }
        public int IdТовара { get; set; }
    }
}
