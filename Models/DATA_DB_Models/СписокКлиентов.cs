using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКлиентов
    {
        public int Id { get; set; }
        public string Наименование { get; set; }
        public string Индекс { get; set; }
        public int IdГорода { get; set; }
        public string УлицаДом { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public string Inn { get; set; }
        public string Окнх { get; set; }
        public string Окпо { get; set; }
        public string Телефоны { get; set; }
        public string Руководитель { get; set; }
        public string История { get; set; }
        public int? Idkart { get; set; }
        public bool ТипКлиента { get; set; }
        public int? Idvo { get; set; }
        public string Кпп { get; set; }
        public string Email { get; set; }
        public string Email1 { get; set; }
        public bool? РассылкаEmail { get; set; }
        public bool? РассылкаEmail1 { get; set; }
        public string ТелефоныДляСервиса { get; set; }
        public string РуководительДляСервиса { get; set; }
        public int Deleted { get; set; }
        public int Изменен { get; set; }
        public int? UserId { get; set; }
        public short? СНдс { get; set; }
    }
}
