using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Работнички
    {
        public int Id { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string ИмяРегистрации { get; set; }
        public byte? Должность { get; set; }
        public string Password { get; set; }
        public string Телефон { get; set; }
        public int? ВедущийМенеджер { get; set; }
        public string Email { get; set; }
        public string Группа { get; set; }
    }
}
