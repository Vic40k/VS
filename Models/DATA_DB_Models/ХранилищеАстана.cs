using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ХранилищеАстана
    {
        public string Адрес { get; set; }
        public string Наименование { get; set; }
        public string Штрихкод { get; set; }
        public int Где { get; set; }
        public string Заказ { get; set; }
        public int? Склад { get; set; }
    }
}
