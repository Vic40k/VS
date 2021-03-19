using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходОбщийДляУтв
    {
        public int IdRecord { get; set; }
        public DateTime? Дата { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? Курс { get; set; }
        public decimal? СуммаРуб { get; set; }
        public int IdСтатьи { get; set; }
        public int IdСубсчета { get; set; }
        public int IdФирмы { get; set; }
        public string НомерСчета { get; set; }
        public string Комментарий { get; set; }
        public bool Разрешение { get; set; }
        public string Поставщик { get; set; }
        public string НомерПлатежки { get; set; }
        public int? IdЮрлица { get; set; }
        public DateTime? ДатаОплаты { get; set; }
        public decimal? СуммаОплаты { get; set; }
        public decimal? КурсОплаты { get; set; }
        public decimal СуммаОплатыРуб { get; set; }
        public bool Директивное { get; set; }
        public int? Кто { get; set; }
        public DateTime? Когда { get; set; }
        public int Пояснение { get; set; }
        public int? RecordSmeta { get; set; }
        public short? Месяц { get; set; }
        public short? Год { get; set; }
        public int? IdЗоны { get; set; }
        public string СтатьяРасхода { get; set; }
        public string Код { get; set; }
        public string Тип { get; set; }
        public string КодЗатрат { get; set; }
        public int? Объект { get; set; }
        public int? ТипДокумента { get; set; }
        public int IdПодразделения { get; set; }
        public int IdСубсчетаРеестра { get; set; }
        public DateTime? ДатаСчета { get; set; }
        public DateTime? ДатаВвода { get; set; }
        public int IdОтветственного { get; set; }
        public bool Наличные { get; set; }
        public int? IdСтатусаСчета { get; set; }
        public DateTime? ДатаУтверждения { get; set; }
        public int IdReestra { get; set; }
        public int? IdСтатусаБюджета { get; set; }
        public int? UserIdСоглас { get; set; }
        public DateTime? ДатаСоглас { get; set; }
        public int? UserIdБухг { get; set; }
        public DateTime? ДатаБухг { get; set; }
        public int? UserIdРег { get; set; }
        public DateTime? ДатаРег { get; set; }
        public int? UserIdИнфр { get; set; }
        public DateTime? ДатаИнфр { get; set; }
        public int? UserIdУтвр { get; set; }
        public int? Ндс { get; set; }
        public int? Отправлено { get; set; }
        public int? IdВалюты { get; set; }
        public decimal? СуммаВал { get; set; }
        public decimal? СуммаОплатыВал { get; set; }
        public int? IdПоставщика { get; set; }
        public string Пост { get; set; }
        public int IdПроизв { get; set; }
    }
}
