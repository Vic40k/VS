using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ConfDisableMenuAsup
    {
        public int RecId { get; set; }
        public int Idizgot { get; set; }
        public string FormName { get; set; }
        public string Action { get; set; }
        public bool Off { get; set; }
        public string Description { get; set; }
    }
}
