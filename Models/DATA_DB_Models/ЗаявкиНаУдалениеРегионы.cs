using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗаявкиНаУдалениеРегионы
    {
        public int Номер { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public int Регион { get; set; }
        public bool ВыписаноРаспоряжение { get; set; }
        public int IdДилера { get; set; }
        public byte УсловияПоставки { get; set; }
        public DateTime Дата { get; set; }
        public string Примечание { get; set; }
    }
}
