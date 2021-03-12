using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class SecUser
    {
        public int Id { get; set; }
        public int? Tab { get; set; }
        public string UserPrim { get; set; }
        public string UserAsup { get; set; }
        public int? IdIzgot { get; set; }
        public int UserGroup { get; set; }
        public DateTime? LastLoggedIn { get; set; }
    }
}
