﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПодробныйСписокНаСкладеВсе
    {
        public string Наименование { get; set; }
        public decimal? Pri { get; set; }
        public decimal? Ras { get; set; }
        public int IdСклада { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public int IdТовара { get; set; }
        public decimal? PriceMin { get; set; }
        public string КодТовара { get; set; }
        public decimal? Nedogr { get; set; }
        public decimal? СвободноОтгрузка { get; set; }
        public decimal? Свободно { get; set; }
        public decimal? СвободноНеделя { get; set; }
        public decimal? Всего { get; set; }
        public decimal? БезРазрешенияЗаявка { get; set; }
    }
}
