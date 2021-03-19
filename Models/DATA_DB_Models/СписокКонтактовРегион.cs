using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокКонтактовРегион
    {
        public int? КодКонтакта { get; set; }
        public int IdКлиента { get; set; }
        public short? ДилерКлиент { get; set; }
        public DateTime? ДатаКонтакта { get; set; }
        public string КонтактноеЛицо { get; set; }
        public string Телефон { get; set; }
        public string Информация { get; set; }
        public int? IdРаботника { get; set; }
        public short? Конф2006 { get; set; }
        public int Регион { get; set; }
        public int RecordId { get; set; }
        public int? ТипКонтакта { get; set; }
        public int? ГруппаПродукта { get; set; }
        public DateTime? ДатаПлана { get; set; }
        public DateTime? ДатаФакта { get; set; }
        public string Исполнение { get; set; }
        public byte[] Файл { get; set; }
        public byte[] ФайлВыставка { get; set; }
        public string Ext1 { get; set; }
        public string Ext2 { get; set; }
        public string Задача { get; set; }
        public DateTime? ДатаЗадачи { get; set; }
        public short? Решена { get; set; }
    }
}
