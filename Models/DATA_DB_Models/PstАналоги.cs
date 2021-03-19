using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstАналоги
    {
        public int BaseId { get; set; }
        public int AnalogId { get; set; }
        public int Order { get; set; }
        public byte TypeId { get; set; }
        public decimal? Count { get; set; }
    }
}
