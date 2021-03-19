using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class БолгарияПриходРасход
    {
        public int Заявка { get; set; }
        public DateTime? ДатаОприходования { get; set; }
        public int UserId { get; set; }
        public int? Поставщик { get; set; }
        public int Грузополучатель { get; set; }
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public string Артикул { get; set; }
        public string НаименованиеBlg { get; set; }
        public decimal Количество { get; set; }
        public int? Партия { get; set; }
        public decimal Цена { get; set; }
        public string ЕдИзм { get; set; }
        public int? IdЕдИзм { get; set; }
        public int Type { get; set; }
    }
}
