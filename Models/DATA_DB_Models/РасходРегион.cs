using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходРегион
    {
        public int IdRecord { get; set; }
        public DateTime? Дата { get; set; }
        public decimal? Сумма { get; set; }
        public decimal? СуммаРуб { get; set; }
        public int? IdСтатьи { get; set; }
        public int? IdСубсчета { get; set; }
        public int IdФирмы { get; set; }
        public int? IdПолучателя { get; set; }
        public int? IdПодразделения { get; set; }
        public string Комментарий { get; set; }
        public int? IdСотрудника { get; set; }
        public bool? Наличные { get; set; }
        public int Регион { get; set; }
        public int? Ндс { get; set; }
        public decimal? СуммаРубБезНдс { get; set; }
        public int? СтавкаНдс { get; set; }
        public decimal? СуммаНдс { get; set; }
        public int? IdПроизв { get; set; }
    }
}
