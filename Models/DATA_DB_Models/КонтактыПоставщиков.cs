using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КонтактыПоставщиков
    {
        public int IdКонтакта { get; set; }
        public int IdПоставщика { get; set; }
        public string Контакт { get; set; }
        public string Значение { get; set; }
        public string Должность { get; set; }
        public string КонтактноеЛицо { get; set; }
        public string Примечание { get; set; }
    }
}
