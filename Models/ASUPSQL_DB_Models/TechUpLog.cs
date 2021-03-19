using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechUpLog
    {
        public int Id { get; set; }
        public string Cpcode { get; set; }
        public int Unit { get; set; }
        public decimal? DetailsSquare { get; set; }
        public string Cpname { get; set; }
        public int? MaterialHeight { get; set; }
        public int? MaterialWidth { get; set; }
        public string MaterialArticle { get; set; }
        public int Iduser { get; set; }
        public DateTime DateChange { get; set; }
        public decimal TimeMash { get; set; }
    }
}
