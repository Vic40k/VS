using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KonPassport
    {
        public int Id { get; set; }
        public int? IdGood { get; set; }
        public string Det { get; set; }
        public string Nom { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
    }
}
