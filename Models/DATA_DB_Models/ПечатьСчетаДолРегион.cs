using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПечатьСчетаДолРегион
    {
        public string Наименование { get; set; }
        public string Название { get; set; }
        public string Телефоны { get; set; }
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public string Примечание { get; set; }
        public int UserId { get; set; }
        public string Фирма { get; set; }
        public string Телефон { get; set; }
        public string БанкРекв { get; set; }
        public string ВБанке { get; set; }
        public string Бик { get; set; }
        public string Город { get; set; }
        public string Инн { get; set; }
        public string Рук { get; set; }
        public string ГлБух { get; set; }
        public decimal Объем { get; set; }
        public int Вес { get; set; }
        public string АдресЮр { get; set; }
        public string Грузоотправитель { get; set; }
        public string КодГорода { get; set; }
        public string Грузополучатель { get; set; }
        public string Kpp { get; set; }
        public int НомерПокупателя { get; set; }
        public string Товар { get; set; }
        public decimal Количество { get; set; }
        public double? Об { get; set; }
        public double? Ве { get; set; }
        public string Артикул { get; set; }
        public string Модель { get; set; }
        public decimal БазоваяЦенаR { get; set; }
        public string КодТовара { get; set; }
        public int? GroupOfGoods { get; set; }
        public string АдресПочт { get; set; }
        public string Нпс { get; set; }
        public string КодРеквизита { get; set; }
        public string ПокупательДляСф { get; set; }
        public DateTime? ДатаКОплате { get; set; }
        public string УсловиеПродажи { get; set; }
        public int Регион { get; set; }
        public string Руководитель { get; set; }
        public string Inn { get; set; }
        public byte Валюта { get; set; }
        public string АдресЮрСтарыеРеквизиты { get; set; }
    }
}
