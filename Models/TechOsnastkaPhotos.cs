using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaPhotos
    {
        public int Key { get; set; }
        public int Keyosn { get; set; }
        public byte Number { get; set; }
        public byte[] Photo { get; set; }
        public string Note { get; set; }
        public bool? Mainphoto { get; set; }
        public string Extension { get; set; }
    }
}
