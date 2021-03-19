using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокОбсуждений
    {
        public int IdОбсуждения { get; set; }
        public string Кто { get; set; }
        public DateTime Дата { get; set; }
        public string Обсуждение { get; set; }
        public int IdТемы { get; set; }
        public string Обсуждение1 { get; set; }
    }
}
