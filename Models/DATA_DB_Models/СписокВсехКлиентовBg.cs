using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокВсехКлиентовBg
    {
        public int Id { get; set; }
        public string Наименование { get; set; }
        public int Регион { get; set; }
        public int ДилерКлиент { get; set; }
        public int IdГорода { get; set; }
        public string УлицаДом { get; set; }
        public string Адрес { get; set; }
        public string ИсполнениеАртикула { get; set; }
        public string ИсполнениеАртикула1 { get; set; }
        public string ИсполнениеАртикула2 { get; set; }
        public int? Дилер { get; set; }
        public double? Отсрочка { get; set; }
        public int Fil { get; set; }
        public string Грузополучатель { get; set; }
        public string ГрузополучательНакладная { get; set; }
        public string Otdel { get; set; }
        public decimal Nds { get; set; }
        public int? Skidka { get; set; }
        public string КодКлиента { get; set; }
        public string История { get; set; }
    }
}
