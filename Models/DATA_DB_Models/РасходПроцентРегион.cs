using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РасходПроцентРегион
    {
        public int НомерПокупателя { get; set; }
        public decimal? СуммаСс { get; set; }
        public decimal? СуммаРас { get; set; }
        public int IdДилера { get; set; }
        public decimal? КолИт { get; set; }
        public int? IdТовара { get; set; }
        public int Регион { get; set; }
        public DateTime? ДатаОтгр { get; set; }
        public int? UserId { get; set; }
    }
}
