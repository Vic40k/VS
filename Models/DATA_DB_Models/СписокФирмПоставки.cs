using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокФирмПоставки
    {
        public int IdФирмы { get; set; }
        public string Фирма { get; set; }
        public string Наименование { get; set; }
        public string АдресЮр { get; set; }
        public string АдресПочт { get; set; }
        public string Телефон { get; set; }
        public string БанкРекв { get; set; }
        public string ВБанке { get; set; }
        public string Бик { get; set; }
        public string Город { get; set; }
        public string Инн { get; set; }
        public string Руководитель { get; set; }
        public string ГлБух { get; set; }
        public bool? Учтена { get; set; }
        public string КодРеквизита { get; set; }
        public string Грузоотправитель { get; set; }
        public short? UsdRuВОфисе { get; set; }
        public string Кпп { get; set; }
        public int FactoryId { get; set; }
    }
}
