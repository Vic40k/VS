using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПерваяДатаОплатыРегион
    {
        public int Регион { get; set; }
        public int Id { get; set; }
        public DateTime? ПерваяДата { get; set; }
        public int? Idvo { get; set; }
    }
}
