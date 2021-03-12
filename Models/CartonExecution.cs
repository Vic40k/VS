using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CartonExecution
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int Sheet { get; set; }
        public int Count { get; set; }
        public int Produced { get; set; }
        public bool IsReuse { get; set; }
        public bool IsUnformat { get; set; }
        public string Operator { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
