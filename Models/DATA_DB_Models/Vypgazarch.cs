using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Vypgazarch
    {
        public int RecordId { get; set; }
        public string Фирма { get; set; }
        public string НомерПп { get; set; }
        public DateTime? ДатаОтпр { get; set; }
        public DateTime? ДатаПол { get; set; }
        public string Сумма { get; set; }
        public string ИннОтпр { get; set; }
        public string Назначение { get; set; }
        public DateTime? ДатаВал { get; set; }
        public string Расч { get; set; }
        public string IdКонтрагента { get; set; }
        public bool? Готово { get; set; }
        public int? UserId { get; set; }
        public bool? Перенесено { get; set; }
        public int? НомерСчета { get; set; }
        public string Контрагент { get; set; }
        public bool? ОбработаноФилиалом { get; set; }
        public int? IdЮрлица { get; set; }
        public int? IdСклада { get; set; }
        public string НомерФилиальный { get; set; }
        public int? RecordKreditnoty { get; set; }
        public bool? ГотовоФил { get; set; }
    }
}
