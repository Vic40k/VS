using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PaintAjurarticleCode
    {
        public int Id { get; set; }
        public string ArticleAjur { get; set; }
        public string ArticleRalcode { get; set; }
        public byte PaintType { get; set; }
    }
}
