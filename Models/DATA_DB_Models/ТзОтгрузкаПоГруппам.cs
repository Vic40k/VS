using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТзОтгрузкаПоГруппам
    {
        public int? IdГруппы { get; set; }
        public string Группа { get; set; }
        public decimal? ВесNetto { get; set; }
        public decimal? ВесБрутто { get; set; }
        public decimal? СуммаРуб { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? Себестоимость { get; set; }
        public decimal? СебестоимостьРуб { get; set; }
        public decimal? Количество { get; set; }
        public int? UserId { get; set; }
        public decimal? СуммаБезНдсРуб { get; set; }
        public decimal? СебестоимостьБезНдсРуб { get; set; }
        public decimal? Объем { get; set; }
        public decimal? СебестоимостьБезНдсСегодня { get; set; }
        public int? Регион { get; set; }
    }
}
