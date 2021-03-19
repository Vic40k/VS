using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlanTaskSectionWork
    {
        public int Id { get; set; }
        public int Idtask { get; set; }
        public int Idproduction { get; set; }
        public byte ItemType { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }
        public int? IdproductionPair { get; set; }
        public int? OrderNumberTo { get; set; }
    }
}
