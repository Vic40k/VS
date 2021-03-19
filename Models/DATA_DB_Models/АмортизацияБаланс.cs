using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class АмортизацияБаланс
    {
        public int IdФирмы { get; set; }
        public int Год { get; set; }
        public int Месяц { get; set; }
        public double ДеньгиВПути { get; set; }
        public double АвансыВыданные { get; set; }
        public double НалоговыеАктивы { get; set; }
        public double КзПоставщики { get; set; }
        public double КзЗп { get; set; }
        public double КзНалоги { get; set; }
        public double Ук { get; set; }
        public double ТмцСырье { get; set; }
        public double ТмцГотоваяПродукцияDib { get; set; }
        public double ТмцОсновныеСредстваНП { get; set; }
        public double ТмцАмортизация { get; set; }
        public string Фирма { get; set; }
        public int BlgTip { get; set; }
    }
}
