using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WarehouseFilter
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public byte FilterIndex { get; set; }
        public string Detail { get; set; }
        public byte ItemType { get; set; }
    }
}
