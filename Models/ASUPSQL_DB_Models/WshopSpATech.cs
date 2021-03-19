using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WshopSpATech
    {
        public int Id { get; set; }
        public int IdArt { get; set; }
        public int IdWp { get; set; }
        public int Status { get; set; }
        public int IdOld { get; set; }
    }
}
