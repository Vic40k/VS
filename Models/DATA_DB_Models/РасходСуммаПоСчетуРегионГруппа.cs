using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходСуммаПоСчетуРегионГруппа
    {
        public int НомерПокупателя { get; set; }
        public decimal? СуммаПоСчету { get; set; }
        public decimal? СуммаПоСс { get; set; }
        public decimal? СуммаПоСчетуРуб { get; set; }
        public int Регион { get; set; }
        public decimal? СуммаПоСчетуБезНдс { get; set; }
        public double? СуммаПоСчетуРубБезНдс { get; set; }
        public DateTime? Отгружена { get; set; }
        public short? Закрыта { get; set; }
        public decimal? СуммаПоОтгр { get; set; }
        public string Наименование { get; set; }
    }
}
