using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class УпдТт
    {
        public int Num { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public decimal Объем { get; set; }
        public double? Вес { get; set; }
        public decimal Количество { get; set; }
        public int НомерСчета { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public string НомерГтд { get; set; }
        public string КодТовара { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string КомуОтпустить { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public DateTime? ДоверенностьДата { get; set; }
        public string Фирма { get; set; }
        public string Expr2 { get; set; }
        public string АдресПочт { get; set; }
        public string АдресЮр { get; set; }
        public string Инн { get; set; }
        public string БанкРек { get; set; }
        public string Грузополучатель { get; set; }
        public string Товар { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public string Фамилия { get; set; }
        public string ГлБух { get; set; }
        public string Грузоотпр { get; set; }
        public int Склад { get; set; }
        public string НомерДоговора { get; set; }
        public int Регион { get; set; }
        public string Имя { get; set; }
        public string Грузоотправитель { get; set; }
        public int? IdПеревозчика { get; set; }
        public string Кпп { get; set; }
        public string Телефон { get; set; }
        public string Руководитель { get; set; }
        public int UserId { get; set; }
        public int IdТовара { get; set; }
        public decimal? ЦенаУзмк { get; set; }
        public int IdСклада { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Отчество { get; set; }
        public DateTime ДатаСчета { get; set; }
        public decimal Nds { get; set; }
        public string SlovaNds { get; set; }
        public short? Префикс { get; set; }
        public string НомерНакл { get; set; }
        public decimal? Ндс { get; set; }
        public string КодСтраны { get; set; }
    }
}
