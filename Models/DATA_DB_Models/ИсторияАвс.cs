using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ИсторияАвс
    {
        public int Код { get; set; }
        public string Тип { get; set; }
        public DateTime? Дата { get; set; }
        public decimal? А { get; set; }
        public decimal? В { get; set; }
        public decimal? С { get; set; }
        public decimal? Аz { get; set; }
        public decimal? Вz { get; set; }
        public decimal? Сz { get; set; }
    }
}
