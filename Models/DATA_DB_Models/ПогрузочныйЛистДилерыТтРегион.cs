using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПогрузочныйЛистДилерыТтРегион
    {
        public int? Номер { get; set; }
        public int Num { get; set; }
        public string КодГорода { get; set; }
        public int? НомерСчета { get; set; }
        public string КомуОтпустить { get; set; }
        public string Наименование { get; set; }
        public string Expr1 { get; set; }
        public string Склад { get; set; }
        public DateTime? Срок { get; set; }
        public DateTime? РаспорСрок { get; set; }
        public bool Оплачена { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public string Товар { get; set; }
        public decimal Количество { get; set; }
        public string КодТовара { get; set; }
        public short? Префикс { get; set; }
        public int Регион { get; set; }
        public string НомерНакл { get; set; }
        public string Артикул { get; set; }
        public string КодРеквизита { get; set; }
        public double? Вес { get; set; }
        public double? Объем { get; set; }
        public string УпаковкаНомер { get; set; }
        public string КтоВОфисе { get; set; }
        public string ПаллетаНомер { get; set; }
        public short КоличествоВУпаковке { get; set; }
        public int? КоличествоВЕдинице { get; set; }
        public string КодЗаказа { get; set; }
        public string Примечание { get; set; }
        public int IdТовара { get; set; }
        public int IdСклада { get; set; }
        public string Грузополучатель { get; set; }
        public string Фирма { get; set; }
        public decimal SsrБезНдс { get; set; }
    }
}
