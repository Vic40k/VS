using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаспоряженияДилДляТтнДляСетей111111
    {
        public string ПунктПогрузки { get; set; }
        public int? IdПеревозчика { get; set; }
        public int IdДилера { get; set; }
        public DateTime Дата { get; set; }
        public string Грузоп { get; set; }
        public string Юрлицо { get; set; }
        public string Юрлицо1 { get; set; }
        public string КомуОтпустить { get; set; }
        public string ПаспортСерияНомер { get; set; }
        public string Доверенность { get; set; }
        public string ДоверенностьДата { get; set; }
        public string Expr1 { get; set; }
        public int? UserId { get; set; }
        public string Примечание { get; set; }
        public string Заказчик { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public string НомТорг { get; set; }
        public int? IdОрганизации { get; set; }
        public string Организация { get; set; }
        public string Водитель { get; set; }
        public string МаркаАвтомобиля { get; set; }
        public string Удостоверение { get; set; }
        public string Госномер { get; set; }
        public string ПунктРазгрузки { get; set; }
        public string КодЗаказа { get; set; }
    }
}
