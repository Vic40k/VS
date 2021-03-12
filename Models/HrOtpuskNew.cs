using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HrOtpuskNew
    {
        public int Id { get; set; }
        public int EdTab { get; set; }
        public DateTime Dbeg { get; set; }
        public DateTime? Dend { get; set; }
        public string Prich { get; set; }
        public int Kol { get; set; }
    }
}
