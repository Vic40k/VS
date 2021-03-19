using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СпецШапкаСпецификации
    {
        public int IdСпецификации { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public DateTime? ДатаНачала { get; set; }
        public int? IdТовара { get; set; }
        public int? UserUtvKon { get; set; }
        public int? UserUtvTech { get; set; }
        public int? UserUtvEn { get; set; }
        public int? UserUtvZak { get; set; }
        public bool? Утверждена { get; set; }
        public DateTime? ДатаУтвKon { get; set; }
        public DateTime? ДатаУтвTech { get; set; }
        public DateTime? ДатаУтвEn { get; set; }
        public DateTime? ДатаУтвZak { get; set; }
        public bool? UtvKon { get; set; }
        public bool UtvTech { get; set; }
        public bool UtvEn { get; set; }
        public bool UtvZak { get; set; }
        public bool УшлоВАсуп { get; set; }
    }
}
