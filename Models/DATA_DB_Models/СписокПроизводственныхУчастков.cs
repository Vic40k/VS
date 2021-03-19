using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокПроизводственныхУчастков
    {
        public int IdУчастка { get; set; }
        public string Участок { get; set; }
        public string Завод { get; set; }
        public decimal? Kfam { get; set; }
    }
}
