using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class Functionality
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public int? Idsegment { get; set; }
        public string Segment { get; set; }
    }
}
