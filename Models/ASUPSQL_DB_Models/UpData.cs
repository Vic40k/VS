using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class UpData
    {
        public string UpCod { get; set; }
        public string UpExt { get; set; }
        public byte[] UpSod { get; set; }
        public string UpExtd { get; set; }
        public byte[] UpSodd { get; set; }
        public string Bai { get; set; }
        public DateTime? DataChange { get; set; }
        public int? IdIzgot { get; set; }
        public int Id { get; set; }
        public string BaiUpdated { get; set; }
    }
}
