using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechUpSt
    {
        public string Bai { get; set; }
        public decimal? Brigada { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Datsavesql { get; set; }
        public bool? Del { get; set; }
        public string EdVr { get; set; }
        public string EdVrOld { get; set; }
        public string FileExt { get; set; }
        public decimal? Heig { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public string KodIzgot { get; set; }
        public string KodOb { get; set; }
        public decimal? KolR { get; set; }
        public string Mat { get; set; }
        public string PLog { get; set; }
        public decimal? Perimetr { get; set; }
        public string Prim { get; set; }
        public decimal? Prioritet { get; set; }
        public bool? Priznak { get; set; }
        public decimal? Skor { get; set; }
        public decimal? Tmash { get; set; }
        public decimal? TmashOld { get; set; }
        public string UpCod { get; set; }
        public string UpNam { get; set; }
        public decimal? Wid { get; set; }
        public bool Delrecord { get; set; }
        public decimal? Gauge { get; set; }
        public bool? MainUp { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public byte? ArchiveTerm { get; set; }
        public bool? ShortTerm { get; set; }
        public DateTime? ShortTermDate { get; set; }
        public string ReasonForArchive { get; set; }
    }
}
