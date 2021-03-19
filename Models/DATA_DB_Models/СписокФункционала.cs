using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокФункционала
    {
        public int Id { get; set; }
        public string Функционал { get; set; }
        public string КодСортировки { get; set; }
        public int Руководитель { get; set; }
        public int? Hid { get; set; }
        public int? Руководитель1 { get; set; }
    }
}
