using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НакладнаяДляТтТранспортная
    {
        public int Num { get; set; }
        public DateTime? ДатаОтпуска { get; set; }
        public double? ВсегоПоТоварам { get; set; }
        public double? ИтогоОбъем { get; set; }
        public double? МассаВсего { get; set; }
        public decimal? ВсегоКол { get; set; }
        public int НомерСчета { get; set; }
        public string Фирма { get; set; }
        public string АдресПочт { get; set; }
        public string АдресЮр { get; set; }
        public string Инн { get; set; }
        public string БанкРек { get; set; }
        public string Грузополучатель { get; set; }
        public string Фамилия { get; set; }
        public string ГлБух { get; set; }
        public string Грузоотпр { get; set; }
        public int Склад { get; set; }
        public int Регион { get; set; }
        public string Имя { get; set; }
        public string Грузоотправитель { get; set; }
        public int? IdПеревозчика { get; set; }
        public string Кпп { get; set; }
        public string Телефон { get; set; }
        public string Руководитель { get; set; }
        public int UserId { get; set; }
        public int? НомерПорядковый { get; set; }
        public string Отчество { get; set; }
        public DateTime ДатаСчета { get; set; }
        public string Водитель { get; set; }
        public string МаркаАвтомобиля { get; set; }
        public string Удостоверение { get; set; }
        public string Госномер { get; set; }
        public string Тип { get; set; }
        public string Грузоподъемность { get; set; }
        public string Вместимость { get; set; }
        public string ПунктПогрузки { get; set; }
        public string Организация { get; set; }
        public string АдресСклада { get; set; }
        public decimal? Nds { get; set; }
    }
}
