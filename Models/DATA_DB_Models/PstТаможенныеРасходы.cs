using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstТаможенныеРасходы
    {
        public int RecordId { get; set; }
        public int IdТовара { get; set; }
        public int Партия { get; set; }
        public string Гтд { get; set; }
        public decimal? ТаможеннаяСтоимостьВВалюте { get; set; }
        public decimal? КурсИнвойса { get; set; }
        public int? IdВалютаИнвойса { get; set; }
        public string ВалютаИнвойса { get; set; }
        public decimal? ТаможеннаяСтоимость { get; set; }
        public decimal? Количество { get; set; }
        public decimal? ТаможенныеПлатежи { get; set; }
        public decimal? ТаможенныеПлатежиДоля { get; set; }
        public decimal? ДоставкаВВалюте { get; set; }
        public decimal? КурсДоставка { get; set; }
        public int? IdВалютаДоставка { get; set; }
        public decimal? Доставка { get; set; }
        public decimal? ДоставкаДоляВВалюте { get; set; }
        public decimal? ДоставкаДоля { get; set; }
        public decimal? ДопРасходыВВалюте { get; set; }
        public decimal? КурсДопРасходы { get; set; }
        public int? IdВалютаДопРасходы { get; set; }
        public decimal? ДопРасходы { get; set; }
        public decimal? ДопРасходыДоляВВалюте { get; set; }
        public decimal? ДопРасходыДоля { get; set; }
        public decimal? Ндс { get; set; }
        public decimal? НдсДоля { get; set; }
        public decimal? ОбщаяСтоимость { get; set; }
        public decimal? ЦенаБезНдс { get; set; }
        public int? UserId { get; set; }
        public int? IdПоставщика { get; set; }
        public DateTime? ДатаДт { get; set; }
        public DateTime? ДатаКурсаИнвойса { get; set; }
        public decimal? КорПошлина { get; set; }
        public decimal? КорПошлинаДоля { get; set; }
        public decimal? КорНдс { get; set; }
        public decimal? КорНдсДоля { get; set; }
        public int? FactoryId { get; set; }
        public int? PrType { get; set; }
        public int? Percent { get; set; }
    }
}
