using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокИсполненийДверейНовый
    {
        public string IdИсполненения { get; set; }
        public string Исполнение { get; set; }
        public decimal? Цена { get; set; }
        public int? АналогПоставки { get; set; }
        public int? АналогДетали { get; set; }
        public string КодСортировки { get; set; }
    }
}
