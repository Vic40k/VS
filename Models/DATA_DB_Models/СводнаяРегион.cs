using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СводнаяРегион
    {
        public int Id { get; set; }
        public int Номер { get; set; }
        public string Наименование { get; set; }
        public decimal Январь { get; set; }
        public decimal Февраль { get; set; }
        public decimal Март { get; set; }
        public decimal Апрель { get; set; }
        public decimal Май { get; set; }
        public decimal Июнь { get; set; }
        public decimal Июль { get; set; }
        public decimal Август { get; set; }
        public decimal Сентябрь { get; set; }
        public decimal Октябрь { get; set; }
        public decimal Ноябрь { get; set; }
        public decimal Декабрь { get; set; }
        public int Регион { get; set; }
        public bool Утвр1 { get; set; }
        public bool Утвр2 { get; set; }
        public bool Утвр3 { get; set; }
        public bool Утвр4 { get; set; }
        public bool Утвр5 { get; set; }
        public bool Утвр6 { get; set; }
        public bool Утвр7 { get; set; }
        public bool Утвр8 { get; set; }
        public bool Утвр9 { get; set; }
        public bool Утвр10 { get; set; }
        public bool Утвр11 { get; set; }
        public bool Утвр12 { get; set; }
    }
}
