using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварныйОтчетПереводыПромЕвросейф
    {
        public string Выражение1 { get; set; }
        public DateTime? ДатаПрихода { get; set; }
        public string Документ { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public string Модель { get; set; }
        public decimal Количество { get; set; }
        public int RecordId { get; set; }
        public int IdФирмы { get; set; }
        public decimal Цена { get; set; }
        public double? СуммаБезНалога { get; set; }
        public double? Ндс { get; set; }
        public double? СуммаСНдс { get; set; }
        public int КодПокупателя { get; set; }
        public decimal Инн { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
    }
}
