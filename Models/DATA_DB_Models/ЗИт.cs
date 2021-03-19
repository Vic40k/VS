using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗИт
    {
        public int Hid { get; set; }
        public int Год { get; set; }
        public int Месяц { get; set; }
        public decimal Ит { get; set; }
        public int? УтвержденоРуководителем { get; set; }
        public decimal КМво { get; set; }
        public decimal Оклад { get; set; }
        public decimal Бонус { get; set; }
        public decimal КИнд1 { get; set; }
        public decimal КИнд2 { get; set; }
        public decimal Доплаты { get; set; }
        public decimal Стаж { get; set; }
        public decimal Выслуга { get; set; }
        public decimal? Премия1 { get; set; }
        public decimal? Премия2 { get; set; }
        public decimal? Nmc { get; set; }
    }
}
