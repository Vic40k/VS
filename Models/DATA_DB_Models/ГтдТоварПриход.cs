using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ГтдТоварПриход
    {
        public int IdТовара { get; set; }
        public string Ордер { get; set; }
        public decimal? Пришло { get; set; }
        public string ДатаГтд { get; set; }
    }
}
