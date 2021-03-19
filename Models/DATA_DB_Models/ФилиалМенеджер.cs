using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ФилиалМенеджер
    {
        public string Фил { get; set; }
        public string Примечание { get; set; }
        public int IdСклада { get; set; }
        public string Пом { get; set; }
        public string ТелефонПом { get; set; }
        public string Телефон { get; set; }
        public byte ТипСклада { get; set; }
        public string Наименование { get; set; }
        public string ФилиалЮр { get; set; }
        public string ИннКпп { get; set; }
        public string УлицаДом { get; set; }
    }
}
