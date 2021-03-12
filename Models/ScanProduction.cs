using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ScanProduction
    {
        public string UserName { get; set; }
        public int Id { get; set; }
        public string Articul { get; set; }
        public string DopCode { get; set; }
        public string Name { get; set; }
        public int? Count { get; set; }
        public string Zakaz { get; set; }
        public DateTime? Date { get; set; }
        public string Zone { get; set; }
        public int? Smena { get; set; }
        public string ZPos { get; set; }
    }
}
