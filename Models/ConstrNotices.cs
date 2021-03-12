using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ConstrNotices
    {
        public int Id { get; set; }
        public int NoticeNumber { get; set; }
        public byte Stage { get; set; }
        public string MainNode { get; set; }
        public int Idgood { get; set; }
    }
}
