using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходПоЗаявкамОтгруженныхСПрефРегион
    {
        public int НомерПокупателя { get; set; }
        public double? СуммаРуб { get; set; }
        public decimal? Сумма { get; set; }
        public string Накладная { get; set; }
        public decimal? Сс { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public short? Префикс { get; set; }
        public int Регион { get; set; }
        public int IdДилера { get; set; }
        public int Id { get; set; }
        public int? Idvo { get; set; }
        public string Наименование { get; set; }
        public double? СуммаРубБезНдс { get; set; }
        public int IdФирмы { get; set; }
        public int? KlientSvoj { get; set; }
        public int? KlientRegSvoj { get; set; }
    }
}
