using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЮрлицаОбъединенные
    {
        public int? РегионЦо { get; set; }
        public int Id { get; set; }
        public string Наименование { get; set; }
        public string Inn { get; set; }
        public string Клиент { get; set; }
        public int RecKl { get; set; }
        public string Объединение { get; set; }
        public int? Idvo { get; set; }
        public double? Штраф { get; set; }
    }
}
