using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходИтогоРегион1111111
    {
        public int IdТовара { get; set; }
        public decimal? Оплачено { get; set; }
        public decimal? Счет { get; set; }
        public decimal? Распоряжение { get; set; }
        public decimal? Недоплачено { get; set; }
        public decimal? Недогрузы { get; set; }
        public decimal? Разрешение { get; set; }
        public int UserId { get; set; }
        public int? IdСклада { get; set; }
        public int? Заказ { get; set; }
        public decimal? Накл { get; set; }
        public decimal? Буфер { get; set; }
        public long Rec { get; set; }
        public decimal? Москва { get; set; }
    }
}
