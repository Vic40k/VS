using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class GoodFile
    {
        public int IdPrj { get; set; }
        public byte[] FileGsu { get; set; }
        public DateTime? DataGsu { get; set; }
        public int StatusGsu { get; set; }
        public int UserGsu { get; set; }
        public byte[] FileImpGsu { get; set; }
        public DateTime? DataImpGsu { get; set; }
        public int StatusImpGsu { get; set; }
        public int UserImpGsu { get; set; }
        public byte[] FileKp { get; set; }
        public DateTime? DataKp { get; set; }
        public int StatusKp { get; set; }
        public int UserKp { get; set; }
        public byte[] FileBil { get; set; }
        public DateTime? DataBil { get; set; }
        public int StatusBil { get; set; }
        public int UserBil { get; set; }
        public byte[] FileZak { get; set; }
        public DateTime? DataZak { get; set; }
        public int StatusZak { get; set; }
        public int UserZak { get; set; }
        public byte[] PicGsu { get; set; }
        public string ExpPicGsu { get; set; }
    }
}
