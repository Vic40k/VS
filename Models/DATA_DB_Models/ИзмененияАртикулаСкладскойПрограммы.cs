using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ИзмененияАртикулаСкладскойПрограммы
    {
        public string IdКонструкции { get; set; }
        public string IdЗамка { get; set; }
        public string IdИсполнения { get; set; }
        public string КодОкраска { get; set; }
        public string КодВн { get; set; }
        public string IdПанелиВн { get; set; }
        public string КодВнут { get; set; }
        public string IdПанелиВнут { get; set; }
        public string IdУпаковки { get; set; }
        public int Rec { get; set; }
        public string КодСортировки { get; set; }
    }
}
