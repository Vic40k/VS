using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗаявкиНаПогрузкуНаНеделю
    {
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public int? НомерВОплате { get; set; }
        public string Название { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public int? Менеджер { get; set; }
    }
}
