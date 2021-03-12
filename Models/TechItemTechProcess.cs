using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechItemTechProcess
    {
        public int Id { get; set; }
        public int IdtechProc { get; set; }
        public int Iditem { get; set; }
        public int NoticeIndex { get; set; }
    }
}
