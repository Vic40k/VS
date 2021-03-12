using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class AccountTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code1C { get; set; }
        public string ExtCode1C { get; set; }
        public string Description { get; set; }
        public bool Calculated { get; set; }
        public string OrderType1 { get; set; }
        public string OrderType2 { get; set; }
        public int DependOnWorkTime { get; set; }
        public bool IsRegular { get; set; }
    }
}
