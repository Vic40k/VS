using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class LbФилиал
    {
        public int Idt { get; set; }
        public int Регион { get; set; }
        public int? Red { get; set; }
        public int? Yellow { get; set; }
        public int? Stop { get; set; }
        public decimal? Мощность { get; set; }
        public int? Норматив { get; set; }
        public decimal? КратностьФил { get; set; }
        public int? LbФил { get; set; }
    }
}
