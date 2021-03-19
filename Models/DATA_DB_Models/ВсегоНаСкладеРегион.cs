using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВсегоНаСкладеРегион
    {
        public string Наименование { get; set; }
        public string КодТовара { get; set; }
        public decimal? Expr1 { get; set; }
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
        public decimal? Vputi { get; set; }
        public int? GroupOfGoods { get; set; }
        public int Регион { get; set; }
        public int БуферУзмк { get; set; }
        public decimal? КратностьУзмк { get; set; }
        public int? Stop { get; set; }
        public int? Yellow { get; set; }
        public bool Тула { get; set; }
        public bool Сосенки { get; set; }
        public string Статус { get; set; }
        public decimal Nds { get; set; }
        public int? Red { get; set; }
        public int IdПодгруппы { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public int? КратностьКроватка { get; set; }
    }
}
