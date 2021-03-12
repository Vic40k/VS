using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CatCatid
    {
        public int Idcat { get; set; }
        public string Nam { get; set; }
        public string Lit { get; set; }
        public int LustArticul { get; set; }
        public int UserUr { get; set; }
        public bool? Root { get; set; }
    }
}
