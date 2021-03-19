using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class IssuingBank
    {
        public int IdissuingBankType { get; set; }
        public string IssuingBankType { get; set; }
        public string Account { get; set; }
        public short? IdВалюты { get; set; }
        public string Фирма { get; set; }
    }
}
