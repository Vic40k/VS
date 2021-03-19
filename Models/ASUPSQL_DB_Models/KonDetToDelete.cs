using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KonDetToDelete
    {
        public int IdRec { get; set; }
        public int IdAs { get; set; }
        public string Nam { get; set; }
        public int IdSmCh { get; set; }
        public string SmCh { get; set; }
        public int IdIzgot { get; set; }
        public int IdUser { get; set; }
        public DateTime DataChange { get; set; }
        public int IdKem { get; set; }
        public bool? Del { get; set; }
        public int IdMat { get; set; }
        public decimal Net { get; set; }
        public decimal Ob { get; set; }
        public int KolGib { get; set; }
        public int KolSv { get; set; }
        public decimal LenSv { get; set; }
        public decimal LenSvZ { get; set; }
        public decimal SsvZ { get; set; }
        public bool? Zag { get; set; }
        public string Det { get; set; }
        public string NamEng { get; set; }
    }
}
