using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HrSmTable
    {
        public string Bai { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? DataReg { get; set; }
        public DateTime? Dateenter { get; set; }
        public DateTime? Dateexit { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string Fio { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public string KodIzgot { get; set; }
        public decimal? Koeff { get; set; }
        public string Prim { get; set; }
        public decimal? Smena { get; set; }
        public decimal? Time { get; set; }
        public bool Delrecord { get; set; }
        public bool? InitiateShortenedTurn { get; set; }
        public decimal? TimeN { get; set; }
        public bool? NoWork { get; set; }
        public int DocId { get; set; }
    }
}
