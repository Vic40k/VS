using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТоваровДляСфАванс
    {
        public int? IdАдреса { get; set; }
        public string Наименование { get; set; }
        public string Индекс { get; set; }
        public string Название { get; set; }
        public string УлицаДом { get; set; }
        public string НаимАдр { get; set; }
        public string Адрес { get; set; }
        public int? IdЮрлица { get; set; }
        public string НаимЮрл { get; set; }
        public int IdГорода { get; set; }
        public int Id { get; set; }
        public int IdКлиента { get; set; }
        public int Номер { get; set; }
        public DateTime? Дата { get; set; }
        public string Примечание { get; set; }
        public int УсловияПоставки { get; set; }
        public string Склад { get; set; }
        public int UserId { get; set; }
        public decimal? Total { get; set; }
        public decimal? ПроцСкидки { get; set; }
        public string Inn { get; set; }
        public string Инн { get; set; }
        public int ЧейКлиент { get; set; }
        public DateTime? ДатаСчетФактуры { get; set; }
        public int? ВнешнийНомер { get; set; }
        public DateTime? ВнешняяДата { get; set; }
        public string Кпп { get; set; }
        public string КппЮрл { get; set; }
        public string ЮрлАдр { get; set; }
        public int НомерПорядковый { get; set; }
        public string Год { get; set; }
        public int? RecordKreditnoty { get; set; }
        public int? IdФирмы { get; set; }
        public string ПокупательДляСф { get; set; }
    }
}
