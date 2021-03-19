using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СпецификацияТрудозатрат
    {
        public int? IdТехпроцесса { get; set; }
        public int? IdБазы { get; set; }
        public decimal? Расценка { get; set; }
        public decimal? Трудоемкость { get; set; }
        public decimal? Цена { get; set; }
    }
}
