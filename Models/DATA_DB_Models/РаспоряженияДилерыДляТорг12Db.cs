using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспоряженияДилерыДляТорг12Db
    {
        public string Грузоп { get; set; }
        public string Юрлицо { get; set; }
        public int IdДилера { get; set; }
        public int Номер { get; set; }
        public int? НомерСчета { get; set; }
        public string КомуОтпустить { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public string ДоверенностьДата { get; set; }
        public string Expr1 { get; set; }
        public bool Оплачена { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public DateTime ДатаЗаявки { get; set; }
        public string КодЗаказа { get; set; }
        public DateTime? ДатаЗаказа { get; set; }
        public string КодМагазина { get; set; }
        public DateTime? ДатаСчетФактуры { get; set; }
        public int? UserId { get; set; }
        public string Товар { get; set; }
        public decimal? Количество { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public string КодТовара { get; set; }
        public double? Вес { get; set; }
        public int? GroupOfGoods { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public int? Префикс { get; set; }
        public string Год { get; set; }
        public int? НомерПорядковый { get; set; }
        public int? IdФирмы { get; set; }
        public string Окпо { get; set; }
        public string ОкпоГр { get; set; }
        public string InnAd { get; set; }
        public string InnUl { get; set; }
        public string Маршрут { get; set; }
        public string ВыставкаДоговор { get; set; }
        public string Password { get; set; }
        public byte UsdRu { get; set; }
        public int IdТовара { get; set; }
        public string След { get; set; }
        public int RecordId { get; set; }
        public string КодГорода { get; set; }
        public string Контракт { get; set; }
        public decimal? Ндс { get; set; }
        public string SlovaNds { get; set; }
        public decimal БазоваяЦенаRДоДоп { get; set; }
        public string Примечание { get; set; }
    }
}
