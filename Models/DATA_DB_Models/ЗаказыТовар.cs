using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЗаказыТовар
    {
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public string Примечание { get; set; }
        public int UserId { get; set; }
        public int IdТовара { get; set; }
        public float Количество { get; set; }
        public int Регион { get; set; }
    }
}
