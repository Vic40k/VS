using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpCat
    {
        public int Id { get; set; }
        public string Cat { get; set; }
        public string CatGr { get; set; }
        public int IdIzgot { get; set; }
        public string Nam { get; set; }
        public bool Del { get; set; }
    }
}
