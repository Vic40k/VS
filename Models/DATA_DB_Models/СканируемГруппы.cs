using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СканируемГруппы
    {
        public int? НомерНакладной { get; set; }
        public string Модель { get; set; }
        public int? Количество { get; set; }
        public int? КоличествоСчитано { get; set; }
        public string ШтрихКод { get; set; }
        public int? ДилерКлиент { get; set; }
        public int? Префикс { get; set; }
        public int? Кто { get; set; }
        public int? IdТовара { get; set; }
        public int? GroupOfGoods { get; set; }
    }
}
