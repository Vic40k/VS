using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstПерсональныйСписокПозиций
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Fio { get; set; }
        public string TemplateName { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Template { get; set; }
    }
}
