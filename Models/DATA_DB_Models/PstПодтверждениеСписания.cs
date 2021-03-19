using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstПодтверждениеСписания
    {
        public int Number { get; set; }
        public DateTime DateTime { get; set; }
        public int TabNbr { get; set; }
        public int? UserId { get; set; }
        public int? Hid { get; set; }
        public string Fio { get; set; }
        public int FactoryId { get; set; }
    }
}
