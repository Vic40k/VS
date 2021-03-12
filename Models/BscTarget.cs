using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class BscTarget
    {
        public int Id { get; set; }
        public int IdWork { get; set; }
        public string NamTarget { get; set; }
        public string TypeTarget { get; set; }
        public int CalcTarget { get; set; }
        public string FuncCalc { get; set; }
        public string Value { get; set; }
        public int UserInput { get; set; }
        public decimal? ValueD { get; set; }
        public DateTime? ValueData { get; set; }
    }
}
