using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПоследняяДатаОплатыРегион
    {
        public DateTime? ПослДата { get; set; }
        public int Idd { get; set; }
        public int Регион { get; set; }
        public string Юрлицо { get; set; }
        public string Дилер { get; set; }
    }
}
