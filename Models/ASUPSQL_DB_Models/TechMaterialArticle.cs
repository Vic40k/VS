using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechMaterialArticle
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public int Idproduction { get; set; }
        public int Idmaterial { get; set; }
        public byte PositionType { get; set; }
        public int Unit { get; set; }
    }
}
