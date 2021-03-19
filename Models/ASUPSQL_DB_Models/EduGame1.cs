using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class EduGame1
    {
        public int IdTr { get; set; }
        public int Comp { get; set; }
        public int Smena { get; set; }
        public string Nam { get; set; }
        public int Kol { get; set; }
        public decimal Price { get; set; }
        public decimal Summ { get; set; }
        public DateTime DateSave { get; set; }
        public int? Order { get; set; }
    }
}
