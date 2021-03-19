using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспоряжениеКлиентыДляТорг12
    {
        public int IdТовара { get; set; }
        public int Номер { get; set; }
        public int? НомерСчета { get; set; }
        public string КомуОтпустить { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public string ДоверенностьДата { get; set; }
        public string Наименование { get; set; }
        public string Expr1 { get; set; }
        public string Склад { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public DateTime? ДатаСчета { get; set; }
        public int? UserId { get; set; }
        public string Примечание { get; set; }
        public int? IdАдреса { get; set; }
        public string Adr { get; set; }
        public int? IdЮрлица { get; set; }
        public string UlUl { get; set; }
        public decimal? Количество { get; set; }
        public decimal? ПроцСкидки { get; set; }
        public DateTime? Дата { get; set; }
        public decimal Expr2 { get; set; }
        public string НомерГтд { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string NaimUl { get; set; }
        public string AdrUl { get; set; }
        public string AdrKl { get; set; }
        public string Inn { get; set; }
        public string Инн { get; set; }
        public string KppKl { get; set; }
        public string KppUl { get; set; }
        public string Индекс { get; set; }
        public string УлицаДом { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public string Название { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string Год { get; set; }
        public int? НомерПорядковый { get; set; }
        public string ОкпоГр { get; set; }
        public string Окпо { get; set; }
    }
}
