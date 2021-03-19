using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходИтогоЦо
    {
        public int? IdТовара { get; set; }
        public double? Оплачено { get; set; }
        public double? Счет { get; set; }
        public double? Распоряжение { get; set; }
        public double? Недоплачено { get; set; }
        public double? Недогрузы { get; set; }
        public int? UserId { get; set; }
    }
}
