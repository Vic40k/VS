using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ИсходныеДанные
    {
        public int? ЗаМесяцИндекс { get; set; }
        public int? Год { get; set; }
        public decimal? ОбщиеПродажиПоИпорту { get; set; }
        public decimal? ОбщиеТранспортныеРасходы { get; set; }
        public decimal? КурсНаПоследнийДеньМесяца { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public string КтоВвел { get; set; }
        public decimal? Комиссия { get; set; }
        public decimal? ПроизводствоСейфы { get; set; }
        public decimal? ПроизводствоМебель { get; set; }
        public decimal? Курс { get; set; }
        public bool? БлокировкаВвода { get; set; }
    }
}
