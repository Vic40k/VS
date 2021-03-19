using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДеревоТоваров2уроверь
    {
        public string Перв { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string Sort { get; set; }
        public string CodeTmc { get; set; }
        public int NodeLevel { get; set; }
        public string SearchId { get; set; }
        public int L1 { get; set; }
        public int L2 { get; set; }
        public string L3 { get; set; }
        public int L4 { get; set; }
    }
}
