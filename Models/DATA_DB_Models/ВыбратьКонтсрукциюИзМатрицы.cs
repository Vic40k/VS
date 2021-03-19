using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ВыбратьКонтсрукциюИзМатрицы
    {
        public string IdКонструкции { get; set; }
        public string Наименование { get; set; }
        public string Категория { get; set; }
        public string Тип { get; set; }
        public string Артикул { get; set; }
        public string Конструкция { get; set; }
        public string ТольщинаПолотна { get; set; }
        public int? КолЗамков { get; set; }
        public string Наполнитель { get; set; }
        public string КоробТолщина { get; set; }
        public string Замок { get; set; }
        public string ЗамокДоп { get; set; }
        public decimal? Цена { get; set; }
        public string IdКатегории { get; set; }
        public int IdКласса { get; set; }
        public decimal? ЦенаТрудозатрат { get; set; }
        public int? IdБазы { get; set; }
        public decimal? ПлощадьМ2 { get; set; }
        public int IdПодгруппы { get; set; }
        public decimal? ЧасыТрудозатрат { get; set; }
        public string IdТипа { get; set; }
        public string КодШирины { get; set; }
    }
}
