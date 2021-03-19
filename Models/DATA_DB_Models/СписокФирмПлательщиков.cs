using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокФирмПлательщиков
    {
        public int IdФирмыПлат { get; set; }
        public string ФирмаПлат { get; set; }
        public string Доступ { get; set; }
        public string Бухгалтер { get; set; }
        public string Руководитель { get; set; }
        public string ИннКпп { get; set; }
        public string Адрес { get; set; }
        public int? Статус { get; set; }
        public int? Ответственный { get; set; }
        public int Основная { get; set; }
    }
}
