using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ConstrSpecifications
    {
        public int Id { get; set; }
        public string Node { get; set; }
        public string Detail { get; set; }
        public int Quantity { get; set; }
        public int Position { get; set; }
        public int Idnotice { get; set; }
        public byte? ItemType { get; set; }
        public int Deleted { get; set; }
    }
}
