using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class KlientyРегион
    {
        public string КодГорода { get; set; }
        public int? Idvo { get; set; }
        public string Наименование { get; set; }
        public string Инн { get; set; }
        public string Кпп { get; set; }
        public string Окнх { get; set; }
        public int? Регион { get; set; }
        public int? Id { get; set; }
        public int? РегРег { get; set; }
        public string КраткоеНаименование { get; set; }
        public string Телефон { get; set; }
        public string Руководитель { get; set; }
        public string Индекс { get; set; }
        public string Город { get; set; }
        public string ФизАдрес { get; set; }
        public string ЮрАдрес { get; set; }
        public string НомерСвид { get; set; }
    }
}
