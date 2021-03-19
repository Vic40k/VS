using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПриходРеестрПодпись
    {
        public int RecordId { get; set; }
        public byte[] Подпись { get; set; }
        public string Фирма { get; set; }
        public string Структурное { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаРуб { get; set; }
        public string Сотрудник { get; set; }
        public string Основание { get; set; }
        public int? ЕстьПодпись { get; set; }
        public DateTime? Дата { get; set; }
        public string Код { get; set; }
        public int? Usd { get; set; }
        public string Вал { get; set; }
        public int? Znak { get; set; }
    }
}
