using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДокументыПретензии
    {
        public int RecordId { get; set; }
        public int? IdПретензии { get; set; }
        public int? IdТипа { get; set; }
        public string Номер { get; set; }
        public DateTime? Дата { get; set; }
        public string Контрагент { get; set; }
        public string Кому { get; set; }
        public int? IdТовара { get; set; }
        public decimal? КолДверей { get; set; }
        public decimal? Сумма { get; set; }
        public byte[] Фото { get; set; }
    }
}
