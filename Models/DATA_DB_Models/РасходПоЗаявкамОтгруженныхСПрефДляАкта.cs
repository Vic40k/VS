using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходПоЗаявкамОтгруженныхСПрефДляАкта
    {
        public double? СуммаОтгр { get; set; }
        public int Регион { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int IdДилера { get; set; }
        public int IdЮрлица { get; set; }
        public int IdФирмы { get; set; }
    }
}
