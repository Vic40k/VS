using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ArticulModelCost
    {
        public int IdRec { get; set; }
        public int IdIzgot { get; set; }
        public string Model { get; set; }
        public string Operation { get; set; }
        public decimal? Tarif { get; set; }
        public double? Norm { get; set; }
        public string KodIzgot { get; set; }
        public string Division { get; set; }
        public string ChangeUser { get; set; }
        public DateTime? ChangeDate { get; set; }
        public bool Delrecord { get; set; }
    }
}
