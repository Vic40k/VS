using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварыДляРаспискиТмпРегион
    {
        public int НомерПокупателя { get; set; }
        public decimal КоличествоКОплате { get; set; }
        public decimal КоличествоОплаченное { get; set; }
        public int Регион { get; set; }
        public double ТмпОпл { get; set; }
        public double ТмпКОпл { get; set; }
    }
}
