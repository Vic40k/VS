using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpHhSalary
    {
        public int Id { get; set; }
        public int IdProf { get; set; }
        public int IdSpec { get; set; }
        public int IdUr { get; set; }
        public string Place { get; set; }
        public DateTime DateSave { get; set; }
        public decimal Salary { get; set; }
    }
}
