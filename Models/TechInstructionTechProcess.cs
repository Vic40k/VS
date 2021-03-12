using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechInstructionTechProcess
    {
        public int Idrec { get; set; }
        public decimal AsVvod { get; set; }
        public decimal AsVyvod { get; set; }
        public string Det { get; set; }
        public int Idizgot { get; set; }
        public decimal NppOper { get; set; }
        public int IdInstr { get; set; }
    }
}
