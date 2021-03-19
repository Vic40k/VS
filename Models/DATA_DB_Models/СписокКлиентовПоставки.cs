using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКлиентовПоставки
    {
        public int Id { get; set; }
        public string Наименование { get; set; }
        public string Индекс { get; set; }
        public int IdГорода { get; set; }
        public string УлицаДом { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public string Inn { get; set; }
        public string Окнх { get; set; }
        public string Окпо { get; set; }
        public string Телефоны { get; set; }
        public string Руководитель { get; set; }
        public string История { get; set; }
        public int? Idkart { get; set; }
        public short? ТипКлиента { get; set; }
        public int? Idvo { get; set; }
        public bool? Дилер { get; set; }
        public short Скидка { get; set; }
        public string Кпп { get; set; }
        public string Грузополучатель { get; set; }
        public string ГрузополучательНакладная { get; set; }
        public string ОкпоПлательщика { get; set; }
        public string ПокупательДляСф { get; set; }
        public string Клиент { get; set; }
        public double? СрокОплаты { get; set; }
        public int? Менеджер { get; set; }
        public int? Охотник { get; set; }
        public string КодВ1с { get; set; }
        public int? Номенклатура { get; set; }
        public int? Планировать { get; set; }
        public string Email { get; set; }
        public string Контакт { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public string ИсточникИнформации { get; set; }
        public int Новый { get; set; }
        public short? Отправка { get; set; }
        public string МобильныйТелефон { get; set; }
        public string Факс { get; set; }
        public int? IdКатегории { get; set; }
        public string IdСтраны { get; set; }
        public int FactoryId { get; set; }
        public bool? Ecbs { get; set; }
    }
}
