using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class OplatyQbРегион
    {
        public string НомерПп { get; set; }
        public DateTime? Дата { get; set; }
        public double? Сумма { get; set; }
        public string КодГородаПокупателя { get; set; }
        public int? Idvo { get; set; }
        public string Покупатель { get; set; }
        public string КодГородаСчета { get; set; }
        public int? Номер { get; set; }
        public DateTime? ДатаСо { get; set; }
        public string Инн { get; set; }
        public int? Регион { get; set; }
        public string Назначение { get; set; }
        public int? IdФирмы { get; set; }
        public string CustomerType { get; set; }
    }
}
