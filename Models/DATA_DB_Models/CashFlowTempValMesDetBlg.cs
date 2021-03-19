using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class CashFlowTempValMesDetBlg
    {
        public int Год { get; set; }
        public int Месяц { get; set; }
        public string Блок { get; set; }
        public string Группа { get; set; }
        public string Подгруппа { get; set; }
        public string КодСтатьи { get; set; }
        public string Наименование { get; set; }
        public string Priz { get; set; }
        public string Код { get; set; }
        public string Статья { get; set; }
        public string Слаг { get; set; }
        public decimal? Валовая { get; set; }
        public decimal? Сим { get; set; }
        public decimal? Змк { get; set; }
        public decimal? Тпо { get; set; }
        public decimal? Об { get; set; }
        public decimal? Dib { get; set; }
        public decimal? Oae { get; set; }
        public decimal? Blg { get; set; }
        public int? IdБлока { get; set; }
        public int? IdГруппы { get; set; }
        public int RecordId { get; set; }
        public decimal? ВаловаяРу { get; set; }
        public decimal? СимРу { get; set; }
        public decimal? ЗмкРу { get; set; }
        public decimal? ТпоРу { get; set; }
        public decimal? ОбРу { get; set; }
        public decimal? DibРу { get; set; }
        public decimal? OaeРу { get; set; }
        public decimal? BlgРу { get; set; }
    }
}
