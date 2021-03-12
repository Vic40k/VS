using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZakПереносСроковЗаказа
    {
        public int Id { get; set; }
        public string NSub { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedDate { get; set; }
        public string User { get; set; }
        public string NBase { get; set; }
        public string Reason { get; set; }
    }
}
