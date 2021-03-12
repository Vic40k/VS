using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class RedSpecHistArchive
    {
        public int IdSpec { get; set; }
        public int IdGood { get; set; }
        public string Det { get; set; }
        public DateTime? DataSt { get; set; }
        public DateTime? DataFin { get; set; }
        public string BaiKon { get; set; }
        public DateTime? DataKon { get; set; }
        public bool UtvKon { get; set; }
        public string BaiTech { get; set; }
        public DateTime? DataTech { get; set; }
        public bool UtvTech { get; set; }
        public string BaiEn { get; set; }
        public DateTime? DataEn { get; set; }
        public bool UtvEn { get; set; }
        public string BaiZak { get; set; }
        public DateTime? DataZak { get; set; }
        public bool UtvZak { get; set; }
        public string BaiSk { get; set; }
        public DateTime? DataSk { get; set; }
        public bool UtvSk { get; set; }
        public string BaiPlant { get; set; }
        public DateTime? DataPlant { get; set; }
        public bool UtvPlant { get; set; }
        public bool UtvVkon { get; set; }
        public string BaiVkon { get; set; }
        public DateTime? DataVkon { get; set; }
        public int Category { get; set; }
        public string BaiEk { get; set; }
        public DateTime? DataEk { get; set; }
        public bool UtvEk { get; set; }
        public DateTime? DataSendEcbs { get; set; }
        public DateTime? DataResiveEcbs { get; set; }
        public string BaiEcbs { get; set; }
        public bool? FlagVes { get; set; }
        public string TextVes { get; set; }
        public DateTime? DataFint { get; set; }
        public int? IdIzgot { get; set; }
        public int NewIzd { get; set; }
        public string Prim { get; set; }
        public string Zamech { get; set; }
        public int? ZamechId { get; set; }
        public bool? UtvNorm { get; set; }
        public DateTime? DataNorm { get; set; }
        public string BaiNorm { get; set; }
        public DateTime? DataFintp { get; set; }
    }
}
