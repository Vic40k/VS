using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class AttMain
    {
        public int IdAtt { get; set; }
        public DateTime DateAtt { get; set; }
        public int IdSpr { get; set; }
    }
}
