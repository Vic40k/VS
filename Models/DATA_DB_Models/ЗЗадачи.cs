using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗЗадачи
    {
        public int RecordId { get; set; }
        public int IdСубсчета { get; set; }
        public int ЛичныйНомер { get; set; }
        public int Год { get; set; }
        public int Месяц { get; set; }
        public string Задача { get; set; }
        public DateTime СрокИсполнения { get; set; }
        public int Приоритет { get; set; }
        public int ТрудоемкостьРаб { get; set; }
        public int ТрудоемкостьНераб { get; set; }
    }
}
