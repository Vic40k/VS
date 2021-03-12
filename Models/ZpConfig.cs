using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpConfig
    {
        public int Id { get; set; }
        public string Nam { get; set; }
        public string Udfname { get; set; }
        public DateTime DataCh { get; set; }
        public string UserCh { get; set; }
    }
}
