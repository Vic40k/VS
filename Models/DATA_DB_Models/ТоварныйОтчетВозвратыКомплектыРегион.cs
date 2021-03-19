using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетВозвратыКомплектыРегион
    {
        public DateTime Дата { get; set; }
        public int Накладная { get; set; }
        public short? Префикс { get; set; }
        public string Наименование { get; set; }
        public decimal Количество { get; set; }
        public string Артикул { get; set; }
        public int Номер { get; set; }
        public string НомерНакл { get; set; }
        public int IdСклада { get; set; }
        public int RecordId { get; set; }
        public string АртикулСост { get; set; }
        public string НаименованиеСост { get; set; }
        public decimal КоличествоСост { get; set; }
        public int? Idfirm { get; set; }
        public string НаименованиеСклада { get; set; }
        public short? ГруппСост { get; set; }
        public string НаименГруппСост { get; set; }
        public string НаименоГруппКомпл { get; set; }
        public short? ГруппКомпл { get; set; }
        public int Регион { get; set; }
        public int ЗаводСклад { get; set; }
    }
}
