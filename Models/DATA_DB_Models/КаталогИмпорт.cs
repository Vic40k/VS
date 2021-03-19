using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class КаталогИмпорт
    {
        public int Код { get; set; }
        public string Менеджер { get; set; }
        public string Sign1 { get; set; }
        public string ТоварнаяГруппа { get; set; }
        public string Sign2 { get; set; }
        public string ТоварнаяПодгруппа { get; set; }
        public string Sign3 { get; set; }
        public string ТоварнаяКатегория { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public int? IdТовара { get; set; }
        public string СтарыйАртикул { get; set; }
        public string СтароеНаименование { get; set; }
        public string НаименованиеДубль1 { get; set; }
        public string IdДубль1 { get; set; }
        public string СтАртикулДубль1 { get; set; }
        public string НаименованиеДубль2 { get; set; }
        public string IdДубль2 { get; set; }
        public string СтАртикулДубль2 { get; set; }
    }
}
