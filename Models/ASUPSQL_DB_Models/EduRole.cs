using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class EduRole
    {
        public int Id { get; set; }
        public int IdTr { get; set; }
        public int Hid { get; set; }
        public string Role1 { get; set; }
        public string Role2 { get; set; }
        public int Ball { get; set; }
    }
}
