﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварыДляLbСим
    {
        public string Наименование { get; set; }
        public int IdТовара { get; set; }
        public string Артикул { get; set; }
        public decimal? Модель { get; set; }
        public decimal? Pri { get; set; }
        public decimal? Ras { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public string КодТовара { get; set; }
        public decimal? Vputi { get; set; }
        public int Vputikl { get; set; }
        public int? Red { get; set; }
        public int? Yellow { get; set; }
        public int? Stop { get; set; }
        public int Буфер { get; set; }
        public decimal? VseRas { get; set; }
        public bool Сосенки { get; set; }
        public decimal? Недогрузы { get; set; }
        public int? Orange { get; set; }
    }
}
