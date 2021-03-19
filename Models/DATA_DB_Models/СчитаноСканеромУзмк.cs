using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СчитаноСканеромУзмк
    {
        public int НомерИзПогрузочного { get; set; }
        public string ШтрихУс { get; set; }
        public int? Считано { get; set; }
        public string Штрих { get; set; }
        public int ДилерКлиент { get; set; }
        public int Префикс { get; set; }
        public int? Регион { get; set; }
    }
}
