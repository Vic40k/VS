using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstПроверкаПоОтветственным
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public DateTime Date { get; set; }
        public int SkladId { get; set; }
        public int UserId { get; set; }
        public int FactoryId { get; set; }
        public DateTime? PlanDate { get; set; }
        public DateTime? DateFix { get; set; }
    }
}
