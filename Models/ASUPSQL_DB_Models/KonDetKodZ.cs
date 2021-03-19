using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KonDetKodZ
    {
        public int Id { get; set; }
        public string Det { get; set; }
        public string CharN { get; set; }
        public decimal Num { get; set; }
        public string Nakl { get; set; }
        public int Code { get; set; }
        public DateTime Date { get; set; }
        public int FactoryId { get; set; }
        public string KeyNumber { get; set; }
        public string PerfomerBrand { get; set; }
    }
}
