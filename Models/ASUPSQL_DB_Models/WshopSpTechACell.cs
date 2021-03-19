using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WshopSpTechACell
    {
        public int Id { get; set; }
        public int IdCell { get; set; }
        public decimal TimCorr { get; set; }
        public int StatusCorr { get; set; }
        public int IdCellOld { get; set; }
    }
}
