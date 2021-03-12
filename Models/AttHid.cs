using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class AttHid
    {
        public int Id { get; set; }
        public int Hid { get; set; }
        public int IdAtt { get; set; }
        public int Prof { get; set; }
        public int NorDoc { get; set; }
        public int Comp { get; set; }
        public int Effect { get; set; }
        public string Dostig { get; set; }
        public string Des { get; set; }
        public string Recom { get; set; }
        public DateTime? DateS { get; set; }
        public string Bai { get; set; }
    }
}
