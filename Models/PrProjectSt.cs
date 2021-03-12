using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PrProjectSt
    {
        public DateTime? Datsavesql { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public DateTime? ProjFinish { get; set; }
        public string ProjKrit { get; set; }
        public string ProjLider { get; set; }
        public string ProjMem { get; set; }
        public string ProjName { get; set; }
        public DateTime? ProjShut { get; set; }
        public DateTime? ProjStart { get; set; }
        public string ProjType { get; set; }
        public bool Delrecord { get; set; }
    }
}
