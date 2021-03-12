using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class SecUserPasCopy
    {
        public DateTime? Data { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string Dopusk { get; set; }
        public string Id { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public string Kod { get; set; }
        public string KodZon { get; set; }
        public string Name { get; set; }
        public string ObjName { get; set; }
        public string Otv { get; set; }
        public bool? Qut { get; set; }
        public bool? Red { get; set; }
        public DateTime? TimeActive { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public decimal? Ur { get; set; }
        public string User { get; set; }
        public bool? Delrecord { get; set; }
        public int? Lang { get; set; }
        public byte? ExtraAccess { get; set; }
        public byte? MainAccessCode { get; set; }
    }
}
