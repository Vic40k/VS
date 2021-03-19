using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class GoodList
    {
        public int IdParent { get; set; }
        public int IdVparent { get; set; }
        public int IdGood { get; set; }
        public int IdVgood { get; set; }
        public int Kol { get; set; }
        public bool? LogCh { get; set; }
    }
}
