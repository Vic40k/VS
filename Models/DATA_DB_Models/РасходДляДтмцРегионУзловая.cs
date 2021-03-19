using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходДляДтмцРегионУзловая
    {
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
        public decimal Kol { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public int Регион { get; set; }
        public int RecordId { get; set; }
        public decimal Ssr { get; set; }
    }
}
