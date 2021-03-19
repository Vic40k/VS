using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class TableForFiles
    {
        public int? Userid { get; set; }
        public string Art { get; set; }
        public string Name { get; set; }
        public string Kol { get; set; }
        public string ArtKl { get; set; }
        public int Rec { get; set; }
        public byte[] Foto { get; set; }
        public int? Номер { get; set; }
        public int? Регион { get; set; }
        public int? Urlico { get; set; }
        public int? Dil { get; set; }
        public int? Skl { get; set; }
    }
}
