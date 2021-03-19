using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПрихНовИзQuickДляПечатиТоргаВсе
    {
        public int IdФирмыКуда { get; set; }
        public int IdФирмыОткуда { get; set; }
        public decimal? ЦенаРуб { get; set; }
        public string Наименование { get; set; }
        public string НаименованиеBlg { get; set; }
        public decimal Количество { get; set; }
        public string Год { get; set; }
        public int НомерПорядковый { get; set; }
        public string Модель { get; set; }
        public string КодТовара { get; set; }
        public double? Вес { get; set; }
        public int IdТовара { get; set; }
        public DateTime? ДатаВывоза { get; set; }
        public int? Партия { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string НомерГтд { get; set; }
        public string СтранаПроисхождения { get; set; }
        public int? GroupOfGoods { get; set; }
        public short? Участок { get; set; }
        public string ЕдИзм { get; set; }
        public string Уч { get; set; }
        public int IdСклада { get; set; }
        public int RecordId { get; set; }
        public double Кф { get; set; }
        public string Артикул { get; set; }
        public int FactoryId { get; set; }
    }
}
