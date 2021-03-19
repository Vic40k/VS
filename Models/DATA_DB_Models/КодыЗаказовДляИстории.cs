using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КодыЗаказовДляИстории
    {
        public int НомерПокупателя { get; set; }
        public string КодЗаказа { get; set; }
        public string ПаллетаНомер { get; set; }
    }
}
