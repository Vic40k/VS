using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокСкладов1
    {
        public int IdСклада { get; set; }
        public string Склад { get; set; }
        public byte ТипСклада { get; set; }
        public string Примечание { get; set; }
        public string Скл { get; set; }
        public int? IdГорода { get; set; }
        public int IdГородаПочт { get; set; }
        public string УлицаДомПочт { get; set; }
        public string ИндексПочт { get; set; }
        public string УлицаДом { get; set; }
        public string Индекс { get; set; }
        public string Директор { get; set; }
        public string НомерТелефона { get; set; }
    }
}
