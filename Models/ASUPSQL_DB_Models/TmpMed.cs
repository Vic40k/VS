using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TmpMed
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public byte Mark { get; set; }
        public string CaptionA { get; set; }
        public string CaptionB { get; set; }
        public bool MarkMaxStacking { get; set; }
        public byte MaxStackingQuantity { get; set; }
    }
}
