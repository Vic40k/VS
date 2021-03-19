using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЖурналИнноваций
    {
        public int RecordId { get; set; }
        public int? КтоВнес { get; set; }
        public DateTime? ДатаРегистрации { get; set; }
        public int? IdИнноватора { get; set; }
        public string Инноватор { get; set; }
        public int? IdСтруктуры { get; set; }
        public string Структура { get; set; }
        public string КраткоеОписаниеИнновации { get; set; }
        public string РешениеКомитетаПоИнновациям { get; set; }
        public int? IdОтветственногоЗаВнедрение { get; set; }
        public string ОтветственныйЗаВнедрение { get; set; }
        public string ГдеВнедрено { get; set; }
        public int? IdКтоПровелАудит { get; set; }
        public string КтоПровелАудит { get; set; }
        public string РезультатыКонтроля { get; set; }
        public DateTime? КогдаПровелАудит { get; set; }
        public int? IdКатегории { get; set; }
        public string ПричинаНеВнедрения { get; set; }
        public string Номер { get; set; }
        public int? Регион { get; set; }
        public byte[] Содержание { get; set; }
        public byte[] Протокол { get; set; }
    }
}
