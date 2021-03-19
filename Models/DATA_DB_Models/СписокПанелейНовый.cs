using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПанелейНовый
    {
        public string IdПанели { get; set; }
        public string Панель { get; set; }
        public string IdТипа { get; set; }
        public string Артикул { get; set; }
        public decimal? Цена { get; set; }
        public string IdКонструкции { get; set; }
        public string КодСортировки { get; set; }
        public string Кратко { get; set; }
    }
}
