using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗЗависимости
    {
        public int Tip { get; set; }
        public decimal VOd { get; set; }
        public decimal VDo { get; set; }
        public decimal Прб { get; set; }
        public decimal Vб { get; set; }
        public decimal Кб { get; set; }
        public decimal Vбрф { get; set; }
        public decimal Vбdib { get; set; }
        public decimal Прбрф { get; set; }
        public decimal Прбdib { get; set; }
        public int RecordId { get; set; }
    }
}
