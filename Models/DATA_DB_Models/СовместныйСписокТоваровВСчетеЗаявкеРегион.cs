using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СовместныйСписокТоваровВСчетеЗаявкеРегион
    {
        public string Наименование { get; set; }
        public int НомерПокупателя { get; set; }
        public decimal Количество { get; set; }
        public byte ДилерКлиент { get; set; }
        public string Артикул { get; set; }
        public short? Префикс { get; set; }
        public decimal КоличествоВСчете { get; set; }
        public int Регион { get; set; }
        public decimal? КоличествоВНалоговой { get; set; }
        public int RecordId { get; set; }
        public int IdТовара { get; set; }
        public decimal КоличествоОплаченное { get; set; }
        public string УпаковкаНомер { get; set; }
        public int? Причина { get; set; }
        public string КодЗаказа { get; set; }
        public decimal? План { get; set; }
        public int? RecVosst { get; set; }
    }
}
