using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КредиторскаяЗадолженностьПоКлиентамПодр
    {
        public string Фирма { get; set; }
        public string Наименование { get; set; }
        public string Фамилия { get; set; }
        public int Номер { get; set; }
        public int? Накладная { get; set; }
        public decimal? SumСуммаДоллары { get; set; }
        public string Юрлицо { get; set; }
        public string ИннЮрлица { get; set; }
        public string Password { get; set; }
        public string Inn { get; set; }
        public decimal? Expr1 { get; set; }
        public int? Менеджер { get; set; }
        public string Bux { get; set; }
    }
}
