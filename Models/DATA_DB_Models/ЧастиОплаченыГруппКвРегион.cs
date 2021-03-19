using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЧастиОплаченыГруппКвРегион
    {
        public int НомерПокупателя { get; set; }
        public int IdТовара { get; set; }
        public decimal? Количество { get; set; }
        public int Регион { get; set; }
    }
}
