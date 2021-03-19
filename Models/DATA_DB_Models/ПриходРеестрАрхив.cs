using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходРеестрАрхив
    {
        public int IdRecord { get; set; }
        public DateTime? Дата { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаРуб { get; set; }
        public int IdПлательщика { get; set; }
        public int? IdСубсчета { get; set; }
        public int IdФирмы { get; set; }
        public string Комментарий { get; set; }
        public int? IdОткуда { get; set; }
        public int? IdПоступления { get; set; }
        public int? IdСчетБалансаДеб { get; set; }
        public int? IdСчетБалансаКред { get; set; }
        public int? RecordIdTo { get; set; }
        public int IdЗоны { get; set; }
        public string Поставщик { get; set; }
        public int? UserId { get; set; }
        public int? RecordFinplan { get; set; }
        public int? IdСтруктуры { get; set; }
        public int BlgTip { get; set; }
        public int? ПриходникРаспечатан { get; set; }
        public decimal? СуммаРубБезНдс { get; set; }
        public int? СтавкаНдс { get; set; }
        public decimal? СуммаНдс { get; set; }
        public int? IdПроизв { get; set; }
    }
}
