using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MobHistory
    {
        public int Idrec { get; set; }
        public string Phone { get; set; }
        public string Post { get; set; }
        public string Fio { get; set; }
        public decimal? Limit { get; set; }
        public string Organization { get; set; }
        public DateTime Period { get; set; }
        public decimal Amount { get; set; }
        public int Idizgot { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? AccountId { get; set; }
    }
}
