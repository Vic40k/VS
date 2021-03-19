using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходБезРазрешенияЗаявка
    {
        public int IdТовара { get; set; }
        public decimal? БезРазрешенияЗаявка { get; set; }
        public int IdСклада { get; set; }
        public int? GroupOfGoods { get; set; }
        public decimal? РазрешениеЗаявка { get; set; }
        public decimal? НакладнаяЗаявкаБезОтгрузки { get; set; }
        public decimal? РазрешениеЗаявкаНеделя { get; set; }
    }
}
