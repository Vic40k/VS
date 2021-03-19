using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class БвГазКв
    {
        public int RecordId { get; set; }
        public string Фирма { get; set; }
        public string НомерПп { get; set; }
        public DateTime? ДатаПол { get; set; }
        public string Сумма { get; set; }
        public string ИннОтпр { get; set; }
        public string Назначение { get; set; }
        public string Расч { get; set; }
        public string IdКонтрагента { get; set; }
        public bool? Готово { get; set; }
        public bool Перенесено { get; set; }
        public int? НомерСчета { get; set; }
        public double? СуммаПп { get; set; }
        public string НомерФилиальный { get; set; }
        public int? Регион { get; set; }
        public bool ОбработаноФилиалом { get; set; }
        public int? RecordKreditnoty { get; set; }
    }
}
