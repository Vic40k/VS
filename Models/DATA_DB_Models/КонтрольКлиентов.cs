using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КонтрольКлиентов
    {
        public int RecordId { get; set; }
        public int? IdКлиента { get; set; }
        public int? IdМенеджера { get; set; }
        public decimal? СуммаОплат { get; set; }
        public decimal? КоличествоСчетов { get; set; }
        public decimal? СуммаОплатЗаПериод { get; set; }
        public decimal? КоличествоСчетовЗаПериод { get; set; }
        public decimal? СуммаАвансов { get; set; }
        public decimal? Доход { get; set; }
        public decimal? ТорговаяНаценка { get; set; }
        public string Комментарий { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public short? Год { get; set; }
        public short? Месяц { get; set; }
    }
}
