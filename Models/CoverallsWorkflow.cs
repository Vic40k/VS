using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CoverallsWorkflow
    {
        public int IdRec { get; set; }
        public string DocId { get; set; }
        public int DocType { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public DateTime Date { get; set; }
        public int Tab { get; set; }
        public int UsefulPeriod { get; set; }
    }
}
