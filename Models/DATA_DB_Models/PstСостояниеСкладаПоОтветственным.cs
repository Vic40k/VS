using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstСостояниеСкладаПоОтветственным
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public DateTime Date { get; set; }
        public int IdСклада { get; set; }
        public int FactoryId { get; set; }
        public int ParentId { get; set; }
        public int IdТовара { get; set; }
        public int? EdIzmId { get; set; }
        public decimal CountInU { get; set; }
        public decimal CountU { get; set; }
        public decimal CountAll { get; set; }
        public decimal FactCountU { get; set; }
        public decimal FactCountAll { get; set; }
    }
}
