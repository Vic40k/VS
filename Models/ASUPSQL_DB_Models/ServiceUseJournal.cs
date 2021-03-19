using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ServiceUseJournal
    {
        public int Id { get; set; }
        public int Idperson { get; set; }
        public DateTime DateTimeAction { get; set; }
        public int Idaction { get; set; }
        public int IdtableRight { get; set; }
    }
}
