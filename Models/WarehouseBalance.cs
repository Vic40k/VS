using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WarehouseBalance
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public int WarehouseIndex { get; set; }
        public byte Month { get; set; }
        public int Year { get; set; }
        public string Detail { get; set; }
        public int Quantity { get; set; }
    }
}
