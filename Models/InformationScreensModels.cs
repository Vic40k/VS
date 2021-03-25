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
		public decimal? Orderquantity { get; set; }
		public DateTime? OrderDate { get; set; }
		public decimal? ProducedQuantity { get; set; }
		public DateTime? WarehouseDate { get; set; }
		public int ShipmentQuantity { get; set; }
		public DateTime? ShipmentDate { get; set; }
		public int StatusId { get; set; }
		public string Status { get; set; }
		public string Client { get; set; }
		public string Comment { get; set; }
		public DateTime? DelayDate { get; set; }
		
		public decimal ReadyForShipmentPercent { get; set; }
		public bool IsDelayed { get; set; }
        public bool IsDelay { get; set; }
        public bool IsOnTime { get; set; }
        public bool IsDelayRisk { get; set; }
        public bool IsShipped { get; set; }
    }
}
