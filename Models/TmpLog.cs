using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TmpLog
    {
        public string Username { get; set; }
        public int? IdIzgot { get; set; }
        public string Computername { get; set; }
        public string Logonserver { get; set; }
        public string Userdnsdomain { get; set; }
        public string Userdomain { get; set; }
        public DateTime? Dat { get; set; }
        public string Login { get; set; }
        public string Ver { get; set; }
    }
}
