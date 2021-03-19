using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокВодителей
    {
        public int IdВодителя { get; set; }
        public string Водитель { get; set; }
        public int? Бригада { get; set; }
        public string МаркаАвтомобиля { get; set; }
        public string Удостоверение { get; set; }
        public string Госномер { get; set; }
        public int? Регион { get; set; }
        public string Тип { get; set; }
        public string Грузоподъемность { get; set; }
        public string Вместимость { get; set; }
        public bool? Внешний { get; set; }
    }
}
