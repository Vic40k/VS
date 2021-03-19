using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Кампании
    {
        public int RecordId { get; set; }
        public int Id { get; set; }
        public int ДилерКлиент { get; set; }
        public int IdКампании { get; set; }
    }
}
