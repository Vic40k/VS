using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СуммаНакладнойРегион
    {
        public int НомерПокупателя { get; set; }
        public double? Сумма { get; set; }
        public double? Вес { get; set; }
        public int Регион { get; set; }
        public int? КолСтрок { get; set; }
        public short? Префикс { get; set; }
        public double? Объем { get; set; }
    }
}
