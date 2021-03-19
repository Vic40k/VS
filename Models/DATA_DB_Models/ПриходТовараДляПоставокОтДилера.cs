using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходТовараДляПоставокОтДилера
    {
        public int IdТовара { get; set; }
        public decimal Количество { get; set; }
        public decimal? Префикс { get; set; }
        public DateTime? ДатаПрихода { get; set; }
        public int? IdЮрлица { get; set; }
        public string Документ { get; set; }
        public string Ордер { get; set; }
        public int UserId { get; set; }
    }
}
