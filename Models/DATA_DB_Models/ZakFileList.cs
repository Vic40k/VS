using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ZakFileList
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int UpdateAlways { get; set; }
        public string State { get; set; }
    }
}
