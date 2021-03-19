using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KachKartFiles
    {
        public int Id { get; set; }
        public int Idcard { get; set; }
        public int DocumentNumber { get; set; }
        public byte[] DocumentFile { get; set; }
        public string FileDescription { get; set; }
        public string FileExtension { get; set; }
    }
}
