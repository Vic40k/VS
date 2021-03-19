using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокЮрлицКлиентовПоставки
    {
        public int IdЮрлица { get; set; }
        public int FactoryId { get; set; }
        public int IdКлиента { get; set; }
        public string Наименование { get; set; }
        public string Адрес { get; set; }
        public string Контакт { get; set; }
        public string Инн { get; set; }
        public string Кпп { get; set; }
        public string БанковскиеРеквизиты { get; set; }
        public bool? Deleted { get; set; }
        public string Окпо { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Огрн { get; set; }
        public string Account { get; set; }
        public string BankName { get; set; }
        public string Bik { get; set; }
        public string Swift { get; set; }
        public string Address { get; set; }
        public string Договор { get; set; }
        public DateTime? ДатаДоговора { get; set; }
        public DateTime? ДатаНачала { get; set; }
        public DateTime? ДатаОкончания { get; set; }
        public int? УсловияОплаты { get; set; }
        public int? УсловияПоставки { get; set; }
        public int? МетодПоставки { get; set; }
        public int? IdВалюты { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
