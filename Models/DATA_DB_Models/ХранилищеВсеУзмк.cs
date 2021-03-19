using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ХранилищеВсеУзмк
    {
        public string Адрес { get; set; }
        public string Наименование { get; set; }
        public string Штрихкод { get; set; }
        public int Где { get; set; }
        public decimal? Остаток { get; set; }
        public int IdТовара { get; set; }
        public int RecordId { get; set; }
        public string ШтрихКодЯчейки { get; set; }
        public string Заказ { get; set; }
        public string ПолноеНаим { get; set; }
        public int? Склад { get; set; }
        public string Клиент { get; set; }
        public string Expr1 { get; set; }
        public double Объем { get; set; }
        public double ВесБрутто { get; set; }
        public string Артикул { get; set; }
        public string Статус { get; set; }
        public int Регион { get; set; }
        public int CellId { get; set; }
        public string Тип { get; set; }
        public DateTime? Срок { get; set; }
    }
}
