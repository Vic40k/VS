using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПоследняяДатаОплатыДляВедущего
    {
        public DateTime? MaxДата { get; set; }
        public int Idd { get; set; }
        public string Название { get; set; }
    }
}
