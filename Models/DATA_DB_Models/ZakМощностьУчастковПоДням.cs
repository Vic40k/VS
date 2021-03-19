using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ZakМощностьУчастковПоДням
    {
        public int Uid { get; set; }
        public DateTime Date { get; set; }
        public int Power { get; set; }
        public int? EditUserId { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
