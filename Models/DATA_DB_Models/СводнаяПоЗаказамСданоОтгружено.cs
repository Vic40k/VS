using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СводнаяПоЗаказамСданоОтгружено
    {
        public int НомерЗаказа { get; set; }
        public DateTime ДатаЗаказа { get; set; }
        public string Заказчик { get; set; }
        public string РегионЗаказчика { get; set; }
        public string Статус { get; set; }
        public DateTime? ТребуемаяДатаОтЗаказчика { get; set; }
        public DateTime? ПринятоВПроизводство { get; set; }
        public DateTime? ДатаОтЗавода { get; set; }
        public float КоличествоВЗаказе { get; set; }
        public decimal? КоличествоСдано { get; set; }
        public decimal? КоличествоВСчетах { get; set; }
        public string НомерЗавода { get; set; }
        public string Примечание { get; set; }
        public string Описание { get; set; }
        public string Базовый { get; set; }
        public string Артикул { get; set; }
        public string Категория { get; set; }
        public DateTime? ДатаПрихода { get; set; }
        public DateTime? ДатаВывоза { get; set; }
    }
}
