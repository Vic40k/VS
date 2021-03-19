using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОсДокументы
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string NbrDocument { get; set; }
        public byte TypeId { get; set; }
        public int? SourceId { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? LastEditDate { get; set; }
        public int? LastEditUserId { get; set; }
    }
}
