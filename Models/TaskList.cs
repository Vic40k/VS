using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TaskList
    {
        public string ProcedureName { get; set; }
        public DateTime? LastRun { get; set; }
        public int EveryMinute { get; set; }
        public bool Active { get; set; }
        public int? ExecTime { get; set; }
        public bool IsRunning { get; set; }
        public string Description { get; set; }
        public string LastError { get; set; }
    }
}
