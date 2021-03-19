using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class KnНеучтВсе
    {
        public decimal? СуммаОпл { get; set; }
        public int? UserId { get; set; }
        public int? IdДилера { get; set; }
        public int? IdЮрлица { get; set; }
        public string Дилер { get; set; }
        public string Юрлицо { get; set; }
    }
}
