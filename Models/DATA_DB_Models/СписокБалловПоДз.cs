using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокБалловПоДз
    {
        public int ДзОт { get; set; }
        public int ДзДо { get; set; }
        public int Балл { get; set; }
        public int НомерСтроки { get; set; }
        public int? БаллДз { get; set; }
    }
}
