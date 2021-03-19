using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокДляЦепи
    {
        public int IdФирмы { get; set; }
        public int FactoryId { get; set; }
        public string Фирма { get; set; }
        public string Грузоотправитель { get; set; }
        public string Поставщик { get; set; }
        public string Окпо { get; set; }
        public string Бухгалтер { get; set; }
        public string Руководитель { get; set; }
        public string Плательщик { get; set; }
        public string ГрузоотправительДляСф { get; set; }
        public string АдресСф { get; set; }
        public string ИннКпп { get; set; }
        public decimal Кф { get; set; }
        public string Основание { get; set; }
        public decimal? Кф1 { get; set; }
        public string ТекстРС { get; set; }
        public string PC { get; set; }
        public string ТекстБанк { get; set; }
        public string Банк { get; set; }
        public string ТекстКС { get; set; }
        public string КС { get; set; }
        public string ТекстБик { get; set; }
        public string Бик { get; set; }
        public string АдресДляШапки { get; set; }
        public string ИннОтдельно { get; set; }
        public string КппОтдельно { get; set; }
        public string АдресДляКорреспонденции { get; set; }
        public string Телефон { get; set; }
        public string Факс { get; set; }
        public string EMail { get; set; }
        public int IsReal { get; set; }
        public int? Hrmid { get; set; }
        public string ГрузоотправительКл { get; set; }
        public string ПоставщикКл { get; set; }
        public string БухгалтерСтарый { get; set; }
        public string ГрузоотправительКлСтарый { get; set; }
        public string ПоставщикКлСтарый { get; set; }
        public string ГрузоотправительДляСфДляСетей { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public string Грузоотправитель22102012 { get; set; }
        public string ГрузоотправительДляСф22102012 { get; set; }
        public string ИннКпп22102012 { get; set; }
        public string ГрузоотправительКл22102012 { get; set; }
        public string ГрузоотправительДляСфТула { get; set; }
        public string БанковскиеРеквизитыДил { get; set; }
        public string Грузоотправитель29072014 { get; set; }
        public string ГрузоотправительДляСф29072014 { get; set; }
        public string ГрузоотправительКл29072014 { get; set; }
        public string Поставщик29072014 { get; set; }
        public string ПоставщикКл29072014 { get; set; }
        public string БанковскиеРеквизитыАльфа { get; set; }
        public string ГрузоотправительДляСф14072016 { get; set; }
    }
}
