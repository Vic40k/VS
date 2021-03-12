using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class Sessions
    {
        public string Token { get; set; }
        public int Hid { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Roles { get; set; }
        public string MachineName { get; set; }
    }
}
