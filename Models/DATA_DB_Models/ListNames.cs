using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ListNames
    {
        public string Id { get; set; }
        public string RusName { get; set; }
        public string AltName { get; set; }
        public int FactoryId { get; set; }
    }
}
