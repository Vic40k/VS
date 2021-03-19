using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class HrSelection
    {
        public int Id { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime? DateReg { get; set; }
        public int Status { get; set; }
        public string Dolg { get; set; }
        public string Code { get; set; }
        public int GraidD { get; set; }
        public int Kol { get; set; }
        public byte[] ExcelDoc { get; set; }
        public DateTime? DateClose { get; set; }
        public int IdIzgot { get; set; }
    }
}
