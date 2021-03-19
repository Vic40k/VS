using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТтнДилеры
    {
        public string Окпо { get; set; }
        public string ОкпоГр { get; set; }
        public string Грузоп { get; set; }
        public string Юрлицо { get; set; }
        public int Номер { get; set; }
        public int Num { get; set; }
        public int? НомерСчета { get; set; }
        public string Зак { get; set; }
        public DateTime? ДатЗак { get; set; }
        public string Наименование { get; set; }
        public string Expr1 { get; set; }
        public string Склад { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public DateTime ДатаЗаявки { get; set; }
        public DateTime? ДатаЗаказа { get; set; }
        public int? UserId { get; set; }
        public string Название { get; set; }
        public string УлицаДом { get; set; }
        public string НазваниеПочт { get; set; }
        public string УлицаДомПочт { get; set; }
        public int? IdЮрлица { get; set; }
        public string Примечание { get; set; }
        public byte UsdRu { get; set; }
        public string Заказчик { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public DateTime? ДатаПлановая { get; set; }
        public string НомерНакл { get; set; }
        public int? НомерПорядковый { get; set; }
        public int Префикс { get; set; }
        public string ПунктРазгрузки { get; set; }
        public int? IdОрганизации { get; set; }
        public string Организация { get; set; }
        public string Водитель { get; set; }
        public string МаркаАвтомобиля { get; set; }
        public string Удостоверение { get; set; }
        public string Госномер { get; set; }
        public int IdДилера { get; set; }
        public string Тип { get; set; }
        public string Грузоподъемность { get; set; }
        public string Вместимость { get; set; }
        public decimal? КолПаллеты { get; set; }
        public int Expr2 { get; set; }
        public string Дир { get; set; }
        public string Кладовщик { get; set; }
        public int? IdФирмы { get; set; }
    }
}
