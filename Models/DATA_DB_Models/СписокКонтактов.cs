using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКонтактов
    {
        public int КодКонтакта { get; set; }
        public int? IdКлиента { get; set; }
        public short? ДилерКлиент { get; set; }
        public DateTime? ДатаКонтакта { get; set; }
        public string КонтактноеЛицо { get; set; }
        public string Телефон { get; set; }
        public string Информация { get; set; }
        public int? IdРаботника { get; set; }
        public short? Конф2006 { get; set; }
        public byte[] Файл { get; set; }
        public byte[] ФайлВыставка { get; set; }
        public int? ТипКонтакта { get; set; }
        public string Ext1 { get; set; }
        public string Ext2 { get; set; }
    }
}
