using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОсЭнергоресурсы
    {
        public int CellId { get; set; }
        public DateTime Date { get; set; }
        public decimal Electric { get; set; }
        public decimal Gas { get; set; }
        public decimal Air { get; set; }
    }
}
