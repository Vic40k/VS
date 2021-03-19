using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class МенеджерыРегион
    {
        public int? Id1 { get; set; }
        public string Expr1 { get; set; }
        public int Регион { get; set; }
        public string Password { get; set; }
        public int? IdЦо { get; set; }
        public string Email { get; set; }
        public string ИмяРегистрации { get; set; }
        public byte Должность { get; set; }
        public string Фамилия { get; set; }
    }
}
