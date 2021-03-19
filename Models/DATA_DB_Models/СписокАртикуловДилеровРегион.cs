using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокАртикуловДилеровРегион
    {
        public int IdТовара { get; set; }
        public string Ean { get; set; }
        public string Artikul { get; set; }
        public string Наименование { get; set; }
        public int IdДилера { get; set; }
        public int? Регион { get; set; }
        public string ArtikulMgb { get; set; }
    }
}
