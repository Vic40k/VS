using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class EquipmentConsumables
    {
        public int IdRec { get; set; }
        public string InvNumber { get; set; }
        public string Event { get; set; }
        public int GoodId { get; set; }
        public double Quantity { get; set; }
        public int UnitCode { get; set; }
    }
}
