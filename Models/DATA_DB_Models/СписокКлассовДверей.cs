using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКлассовДверей
    {
        public string IdТипа { get; set; }
        public string Тип { get; set; }
        public string IdКатегории { get; set; }
        public int IdКласса { get; set; }
    }
}
