using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокИзмененийСкидки
    {
        public int ОтсрочкаОт { get; set; }
        public int? ОтсрочкаДо { get; set; }
        public decimal ИзменениеСкидки { get; set; }
        public int? НомерСтроки { get; set; }
    }
}
