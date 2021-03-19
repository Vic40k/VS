using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PersonsConnections
    {
        public int Id { get; set; }
        public int Idpost { get; set; }
        public int Idperson { get; set; }
        public int? Idchief { get; set; }
        public int? Idgroup { get; set; }
        public bool SendNote { get; set; }
        public byte Unit { get; set; }
        public string PathForDrafts { get; set; }
        public bool SendCardPermission { get; set; }
        public byte? SendNoteTechNotice { get; set; }
        public string PathForDraftEnter { get; set; }
    }
}
