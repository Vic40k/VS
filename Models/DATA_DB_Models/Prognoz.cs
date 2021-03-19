using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Prognoz
    {
        public int Id { get; set; }
        public string Art { get; set; }
        public string Name { get; set; }
        public int? Mes { get; set; }
        public int? God { get; set; }
    }
}
