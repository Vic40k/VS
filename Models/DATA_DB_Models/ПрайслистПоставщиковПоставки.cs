using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПрайслистПоставщиковПоставки
    {
        public int IdКлиента { get; set; }
        public int IdЮрлица { get; set; }
        public int IdТовара { get; set; }
        public int IdВалюты { get; set; }
        public decimal Цена { get; set; }
        public decimal Скидка { get; set; }
        public int FactoryId { get; set; }
    }
}
