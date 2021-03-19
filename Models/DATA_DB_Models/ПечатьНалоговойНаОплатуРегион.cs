using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПечатьНалоговойНаОплатуРегион
    {
        public DateTime FirstДатаПр { get; set; }
        public int Номер { get; set; }
        public int НомерСчета { get; set; }
        public string Кл { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Склад { get; set; }
        public DateTime? Срок { get; set; }
        public DateTime? РаспорСрок { get; set; }
        public bool Оплачена { get; set; }
        public DateTime ДатаОтпуска { get; set; }
        public DateTime ДатаЗаявки { get; set; }
        public DateTime? ДатаЗаказа { get; set; }
        public DateTime? ДатаСчетФактуры { get; set; }
        public int UserId { get; set; }
        public string Фирма { get; set; }
        public string КодГорода { get; set; }
        public string АдресЮр { get; set; }
        public string Название { get; set; }
        public string УлицаДом { get; set; }
        public string Инн { get; set; }
        public string Товар { get; set; }
        public double Количество { get; set; }
        public int НомерПокупателя { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public double БазоваяЦена { get; set; }
        public double БазоваяЦенаR { get; set; }
        public double? Вес { get; set; }
        public string Индекс { get; set; }
        public string ГлБух { get; set; }
        public double? Цена { get; set; }
        public double? Сумма { get; set; }
        public double? Итого { get; set; }
        public short? Префикс { get; set; }
        public string НомерНакл { get; set; }
        public int НомерПорядковый { get; set; }
        public string Inn { get; set; }
        public string Окпо { get; set; }
        public string Нпс { get; set; }
        public string Телефоны { get; set; }
        public string Телефон { get; set; }
        public int Регион { get; set; }
        public string Год { get; set; }
        public string ПокупательДляСф { get; set; }
    }
}
