using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TabloCfg
    {
        public int Id { get; set; }
        public string IdTablo { get; set; }
        public int? IdIzgot { get; set; }
        public string KodIzgot { get; set; }
        public int? Interval { get; set; }
        public int? KolStr { get; set; }
        public int? FontSize { get; set; }
        public string Comment { get; set; }
        public int? Pole1 { get; set; }
        public int? Pole2 { get; set; }
        public int? IdGroup { get; set; }
        public int? IdSubGroup { get; set; }
        public int? Pole3 { get; set; }
        public bool? Plant { get; set; }
        public bool? IsGroupTablo { get; set; }
        public string IdGroupTablo { get; set; }
        public int? PageGroupTablo { get; set; }
    }
}
