using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТем
    {
        public int IdТемы { get; set; }
        public string Тема { get; set; }
        public string Статус { get; set; }
        public string КтоИнициировал { get; set; }
        public string ПервичноеПредложение { get; set; }
        public DateTime ДатаПодачи { get; set; }
        public int UserId { get; set; }
    }
}
