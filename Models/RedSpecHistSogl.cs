using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class RedSpecHistSogl
    {
        public int IdSpec { get; set; }
        public int IdIzgot { get; set; }
        public DateTime? DataFint { get; set; }
        public bool? UtvTech { get; set; }
        public DateTime? DataTech { get; set; }
        public bool? UtvSk { get; set; }
        public DateTime? DataSk { get; set; }
        public bool? UtvPlant { get; set; }
        public DateTime? DataPlant { get; set; }
    }
}
