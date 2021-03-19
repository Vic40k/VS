using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class WarehousePlace
    {
        public int Id { get; set; }
        public int IdТовара { get; set; }
        public string Этаж { get; set; }
        public string Стелаж { get; set; }
        public string Полка { get; set; }
        public int FactoryId { get; set; }
        public string Оборудование { get; set; }
        public byte Склад { get; set; }
    }
}
