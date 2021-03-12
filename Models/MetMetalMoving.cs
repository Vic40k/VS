using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class MetMetalMoving
    {
        public int Idrec { get; set; }
        public int TabN { get; set; }
        public int MachKodizgot { get; set; }
        public int MachNn { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
        public int Shift { get; set; }
        public int? ObjectId { get; set; }
        public int Count { get; set; }
        public string Operation { get; set; }
        public string Comment { get; set; }
        public int Idizgot { get; set; }
        public bool Delrecord { get; set; }
        public DateTime? Datsavesql { get; set; }
    }
}
