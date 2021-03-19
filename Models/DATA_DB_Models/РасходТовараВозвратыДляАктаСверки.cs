using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходТовараВозвратыДляАктаСверки
    {
        public double? СуммаОтгр { get; set; }
        public DateTime? ДатаПрихода { get; set; }
        public int IdДилера { get; set; }
        public byte UsdRu { get; set; }
        public int? IdЮрлица { get; set; }
        public int RecordId { get; set; }
    }
}
