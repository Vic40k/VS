using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ZakПроцентРезервированияМощностиУчастков
    {
        public int Uid { get; set; }
        public decimal Percent { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? EditDate { get; set; }
        public int? CreatedUser { get; set; }
        public int? EditUser { get; set; }
    }
}
