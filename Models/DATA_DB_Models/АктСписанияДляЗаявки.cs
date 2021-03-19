using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class АктСписанияДляЗаявки
    {
        public string Товар { get; set; }
        public decimal? Количество { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public string Распор { get; set; }
        public string Причина { get; set; }
        public int Номер { get; set; }
        public DateTime? MinOfДатаПрихода { get; set; }
        public string FirstOfДокумент { get; set; }
    }
}
