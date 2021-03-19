using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class АктСверкиРегион
    {
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public int? Счет { get; set; }
        public string Накладная { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public double? СуммаРуб { get; set; }
        public double? КолОтгр { get; set; }
        public int? Префикс { get; set; }
        public string НомерПп { get; set; }
        public DateTime? ДатаПп { get; set; }
        public double? СуммаОплаты { get; set; }
        public double? КолСпис { get; set; }
        public int? СуммаРуб1 { get; set; }
        public string НомерНакл { get; set; }
        public int? IdДилера { get; set; }
        public int? Регион { get; set; }
        public int? UserId { get; set; }
        public double? СсОтгр { get; set; }
        public double? СсСпи { get; set; }
    }
}
