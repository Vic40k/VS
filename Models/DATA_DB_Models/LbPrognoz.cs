using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class LbPrognoz
    {
        public string Наименование { get; set; }
        public string Группа { get; set; }
        public string Подгруппа { get; set; }
        public string Статус { get; set; }
        public int IdТовара { get; set; }
        public decimal? Всего { get; set; }
        public decimal? СвободноНеделя { get; set; }
        public decimal? СвободноОтгрузка { get; set; }
        public decimal? Свободно { get; set; }
        public decimal? ЗаказКратность { get; set; }
        public int? Мжз { get; set; }
        public decimal? ЗаказРекомендация { get; set; }
        public int? ПорогБольшихОтгрузок { get; set; }
        public decimal? КратностьСосенки { get; set; }
        public string Артикул { get; set; }
        public string Участок { get; set; }
    }
}
