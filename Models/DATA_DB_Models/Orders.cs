using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Orders
    {
        public string НомерЗаказа { get; set; }
        public string ТипЗаказа { get; set; }
        public short Опл { get; set; }
        public short Пол { get; set; }
        public string НомерПроформы { get; set; }
        public string НомерИнвойса { get; set; }
        public string Вариант { get; set; }
        public short? КоличествоКонтейнеров { get; set; }
        public decimal? СтоимостьЗаказа { get; set; }
        public short? IdMetodOfPayment { get; set; }
        public double? IdMetodOfTransport { get; set; }
        public short? IdDeliveryTerm { get; set; }
        public DateTime? ДатаПрибытияРасчетная { get; set; }
        public DateTime? RealArriveDate { get; set; }
        public short IdПоставщика { get; set; }
        public double? IdПокупателя { get; set; }
        public double? IdСклада { get; set; }
        public double? IdManager { get; set; }
        public double? IdВалюты { get; set; }
        public decimal? FreightCharges { get; set; }
        public decimal? InsCharges { get; set; }
        public DateTime? ДатаВнесенияИзменений { get; set; }
        public string ИзмененияВнес { get; set; }
        public string Примечание { get; set; }
        public int? IdПеревозчика { get; set; }
        public double? СтоимостьПеревозки { get; set; }
        public bool? ОплатаЗаПеревозкуПоставщику { get; set; }
        public int IdOrder { get; set; }
        public DateTime? ДатаОтгрузки { get; set; }
        public DateTime? ДатаОплаты { get; set; }
        public double? Скидка { get; set; }
        public double? СуммаФактическая { get; set; }
        public DateTime? ДатаРазмещенияЗаказа { get; set; }
        public string ДатаПрибытияДляОтечественных { get; set; }
        public string НомерЗаказаДляПеревозчика { get; set; }
        public DateTime? ДатаОтгрузкиПлановая { get; set; }
        public DateTime? ДатаПрибытияФактическая { get; set; }
        public DateTime? ДатаПрибытияПлановая { get; set; }
        public int? IdТипаГруза { get; set; }
        public double? ПроцентСтраховки { get; set; }
        public double? СтоимостьСтраховки { get; set; }
        public double? СтоимостьТаможня { get; set; }
        public double? СтоимостьТаможняОсобая { get; set; }
        public double? СтоимостьПрочая { get; set; }
        public short? IdПостДост { get; set; }
        public short? IdПостТам { get; set; }
        public short? IdПостСтрах { get; set; }
        public DateTime? ДатаРастаможки { get; set; }
        public bool? СебестоимостьСформирована { get; set; }
        public double? СкидкаАбсолютная { get; set; }
        public short? СтатусЗаявки { get; set; }
        public string НомерЗаявки { get; set; }
        public DateTime? ДатаЗаявки { get; set; }
        public string Ответственный { get; set; }
        public double? СуммаВДолларах { get; set; }
        public string НомерКонтейнера { get; set; }
        public DateTime? ДатаПрибытияВПорт { get; set; }
        public DateTime? ДатаПрибытияВМоскву { get; set; }
    }
}
