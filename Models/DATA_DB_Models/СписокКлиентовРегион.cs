using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКлиентовРегион
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
        public bool? ТипКлиента { get; set; }
        public int? Idvo { get; set; }
        public bool? Дилер { get; set; }
        public short? Скидка { get; set; }
        public string Кпп { get; set; }
        public string Грузополучатель { get; set; }
        public string ГрузополучательНакладная { get; set; }
        public string ОкпоПлательщика { get; set; }
        public string ПокупательДляСф { get; set; }
        public string Клиент { get; set; }
        public double? СрокОплаты { get; set; }
        public int Регион { get; set; }
        public string Договор { get; set; }
        public double? Штраф { get; set; }
        public int? Менеджер { get; set; }
        public int? МаксимальныйКредит { get; set; }
        public byte? Deleted { get; set; }
        public int? IdВыставки { get; set; }
        public string Email { get; set; }
        public string Email1 { get; set; }
        public bool? РассылкаEmail { get; set; }
        public bool? РассылкаEmail1 { get; set; }
        public string ПунктРазгрузки { get; set; }
        public decimal? Ндс { get; set; }
        public string КппТорг12 { get; set; }
        public short КппСфИзАдреса { get; set; }
        public short? СНдс { get; set; }
        public string ИдНомер { get; set; }
        public string Огрн { get; set; }
        public string КомуОтпустить { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public DateTime? ДоверенностьДата { get; set; }
        public int RecKl { get; set; }
        public int? РегионХозяин { get; set; }
        public int? МткХозяин { get; set; }
    }
}
