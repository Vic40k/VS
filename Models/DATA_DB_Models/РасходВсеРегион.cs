using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходВсеРегион
    {
        public int IdСклада { get; set; }
        public string Наименование { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public string Артикул { get; set; }
        public string Товар { get; set; }
        public decimal? Количество { get; set; }
        public string Накладная { get; set; }
        public string Основание { get; set; }
        public int? GroupOfGoods { get; set; }
        public string Группа { get; set; }
        public double Вес { get; set; }
        public double ВесБрутто { get; set; }
        public double Объем { get; set; }
        public int НомерПокупателя { get; set; }
        public int? Считано { get; set; }
        public string Fio { get; set; }
        public int Регион { get; set; }
        public int? RecordId { get; set; }
    }
}
