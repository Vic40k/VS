using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class PlantMetalMachine
    {
        public int Id { get; set; }
        public DateTime TurnDate { get; set; }
        public int Idmachine { get; set; }
        public int Idperson { get; set; }
        public int Idmaterial { get; set; }
        public byte TransactionType { get; set; }
        public decimal Quantity { get; set; }
        public byte MeasureUnit { get; set; }
    }
}
