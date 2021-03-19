using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WarehouseList
    {
        public int Id { get; set; }
        public int Unit { get; set; }
        public byte WarehouseIndex { get; set; }
        public DateTime Date { get; set; }
        public string Detail { get; set; }
        public int Quantity { get; set; }
        public bool InOrOut { get; set; }
        public string Comment { get; set; }
        public int? Idrelated { get; set; }
        public byte TransactionType { get; set; }
        public byte WarehouseToIndex { get; set; }
    }
}
