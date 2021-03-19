using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaRoles
    {
        public int Key { get; set; }
        public int? KodOsn { get; set; }
        public string NamOsnFull { get; set; }
        public string NamOsnShort { get; set; }
        public int? CombineWithRole { get; set; }
    }
}
