using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОтчетыПоАвансам
    {
        public int RecordId { get; set; }
        public int RecordRashod { get; set; }
        public string Документ { get; set; }
        public DateTime? Дата { get; set; }
        public decimal Сумма { get; set; }
        public decimal СуммаРуб { get; set; }
        public string Руководитель { get; set; }
    }
}
