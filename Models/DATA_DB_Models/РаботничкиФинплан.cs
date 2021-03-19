using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class РаботничкиФинплан
    {
        public int Id { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string ИмяРегистрации { get; set; }
        public int? Должность { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? Уволен { get; set; }
        public int? Отдел { get; set; }
        public int Регион { get; set; }
        public string ФамилияEn { get; set; }
        public string ИмяEn { get; set; }
        public string Телефон { get; set; }
        public string Факс { get; set; }
        public byte ДолжностьПоставка { get; set; }
        public int? IdФирмы { get; set; }
        public byte ДолжностьКадры { get; set; }
        public byte ДолжностьОс { get; set; }
        public int? IdЛюди { get; set; }
        public byte ДолжностьЗп { get; set; }
        public byte? ДолжностьИнновации { get; set; }
        public string PasswordKadry { get; set; }
        public byte? ДолжностьОценкаПерсонала { get; set; }
    }
}
