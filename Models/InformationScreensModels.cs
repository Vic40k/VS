using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class InformationScreenViewModel
    {
        public int Order { get; set; }
		public int Region { get; set; }
		public int Orderquantity { get; set; }
		public DateTime OrderDate { get; set; }
		public int ProducedQuantity { get; set; }
		public DateTime WarehouseDate { get; set; }
		public int ShipmentQuantity { get; set; }
		public DateTime ShipmentDate { get; set; }
		public int StatusId { get; set; }
		public string Status { get; set; }
		public string Client { get; set; }
		public int Reason { get; set; } 
		public string Coment { get; set; }
		public DateTime DelayDate { get; set; }
    }
}
