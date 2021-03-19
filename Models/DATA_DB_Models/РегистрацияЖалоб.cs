using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РегистрацияЖалоб
    {
        public int RecordId { get; set; }
        public DateTime? Дата { get; set; }
        public string ОтКого { get; set; }
        public int? ТипКлиента { get; set; }
        public string ВЧейАдрес { get; set; }
        public string ПредметЖалобы { get; set; }
        public string ПринятыеМеры { get; set; }
        public bool? ОтметкаОбИсполнении { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public int? КтоВнес { get; set; }
    }
}
