using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НоменклатураТоваровПоставкиАрхив
    {
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public string НаименованиеBlg { get; set; }
        public string АртикулНовый { get; set; }
        public int? GroupOfGoods { get; set; }
        public int? ТипГруппы { get; set; }
        public int? IdКатегории { get; set; }
        public string IdЕдИзм { get; set; }
        public string СтранаПроисхождения { get; set; }
        public string НомерГтд { get; set; }
        public string IdCalcЕдИзм { get; set; }
        public decimal? CalcKoef { get; set; }
        public string Abc { get; set; }
        public decimal? Буфер { get; set; }
        public int? CreaterId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LastEditId { get; set; }
        public DateTime? LastEditDate { get; set; }
        public decimal? Zapas { get; set; }
        public decimal? ZapasUzmk { get; set; }
        public int? Род { get; set; }
        public int? Поставщик { get; set; }
        public int Грузополучатель { get; set; }
        public int Грузоотправитель { get; set; }
        public decimal? КоэфИсп { get; set; }
        public string ШифрАсуп { get; set; }
        public string Модель { get; set; }
        public string Place { get; set; }
        public string Obor { get; set; }
        public string Категория { get; set; }
        public string ЕдИзм { get; set; }
        public double Кф { get; set; }
        public int Скл { get; set; }
        public int? Red { get; set; }
        public int? Yellow { get; set; }
        public int? Stop { get; set; }
        public short? Kanban { get; set; }
        public short? КоличествоВУпаковке { get; set; }
        public int? IdПодгруппы { get; set; }
        public string КодВ1с { get; set; }
        public string Примечание { get; set; }
        public string КодТовара { get; set; }
        public short? ОтрицательноеКолВо { get; set; }
        public double? Объем { get; set; }
        public double? Вес { get; set; }
        public string Артикул { get; set; }
        public string КодВ1сПоставщика { get; set; }
        public bool Deleted { get; set; }
        public string Контроль { get; set; }
        public bool? Ecbs { get; set; }
        public decimal? Density { get; set; }
        public decimal? Thickness { get; set; }
    }
}
