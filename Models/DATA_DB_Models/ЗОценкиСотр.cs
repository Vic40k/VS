using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗОценкиСотр
    {
        public int Hid { get; set; }
        public int? RecOценка { get; set; }
        public string Ответственный { get; set; }
        public string Фио { get; set; }
        public string КМво1 { get; set; }
        public string КМво2 { get; set; }
        public string КМво3 { get; set; }
        public string КМво4 { get; set; }
        public string КМво5 { get; set; }
        public string КМво6 { get; set; }
    }
}
