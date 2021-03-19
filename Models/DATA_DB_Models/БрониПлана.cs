using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class БрониПлана
    {
        public int RecordId { get; set; }
        public int Номер { get; set; }
        public short ДилерКлиент { get; set; }
        public decimal Бронь { get; set; }
        public int RecordPlana { get; set; }
        public int IdТовара { get; set; }
        public int? РегионЗабронировал { get; set; }
        public int? НомерРегиона { get; set; }
        public int? НомерНедели { get; set; }
    }
}
