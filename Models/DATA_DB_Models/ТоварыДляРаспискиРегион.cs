using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ТоварыДляРаспискиРегион
    {
        public int НомерПокупателя { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public decimal? Количество { get; set; }
        public decimal ЦенаПродажи { get; set; }
        public decimal ЦенаПродажиR { get; set; }
        public double Объем { get; set; }
        public double Вес { get; set; }
        public int IdСклада { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public byte ОбоснованиеБлокировки { get; set; }
        public decimal БазоваяЦена { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public string КодТовара { get; set; }
        public decimal КоличествоКОплате { get; set; }
        public decimal? КоличествоОплаченное { get; set; }
        public int? RecordId { get; set; }
        public int Регион { get; set; }
        public decimal? Nds { get; set; }
        public int? KlientReg { get; set; }
        public int RecKl { get; set; }
    }
}
