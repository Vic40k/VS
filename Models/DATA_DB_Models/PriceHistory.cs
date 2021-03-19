using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PriceHistory
    {
        public int RecordId { get; set; }
        public DateTime? Дата { get; set; }
        public int? IdТовара { get; set; }
        public decimal Price { get; set; }
        public decimal Sebestoimost { get; set; }
        public Guid? Test { get; set; }
        public byte[] ЧертежBin { get; set; }
    }
}
