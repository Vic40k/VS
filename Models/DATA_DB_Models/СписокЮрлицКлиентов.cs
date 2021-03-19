using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЮрлицКлиентов
    {
        public int IdЮрлица { get; set; }
        public int IdКлиента { get; set; }
        public string Наименование { get; set; }
        public string Адрес { get; set; }
        public string Контакт { get; set; }
        public string Инн { get; set; }
        public string Кпп { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public bool? Deleted { get; set; }
        public string Окпо { get; set; }
        public string ПокупательДляСф { get; set; }
        public short? СНдс { get; set; }
    }
}
