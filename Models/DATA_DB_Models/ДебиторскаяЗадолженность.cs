using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДебиторскаяЗадолженность
    {
        public string Фирма { get; set; }
        public decimal? TkВид { get; set; }
        public string Валюта { get; set; }
        public decimal? Cc { get; set; }
    }
}
