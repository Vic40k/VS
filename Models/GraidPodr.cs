using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class GraidPodr
    {
        public int Id { get; set; }
        public string TypPodr { get; set; }
        public int? IdPodr { get; set; }
        public int? IdGrGroup { get; set; }
    }
}
