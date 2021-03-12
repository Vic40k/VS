using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class LocksЗамки
    {
        public int LockId { get; set; }
        public int FactoryId { get; set; }
        public string LockName { get; set; }
        public string ArticulTo { get; set; }
        public int Model { get; set; }
        public int Version { get; set; }
        public int Number { get; set; }
        public int? ReportId { get; set; }
    }
}
