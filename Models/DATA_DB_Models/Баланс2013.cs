using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Баланс2013
    {
        public int Месяц { get; set; }
        public double Деньги { get; set; }
        public double ДеньгиВПути { get; set; }
        public double ДзКлиента { get; set; }
        public double ДзПоставщика { get; set; }
        public double ТмцГотоваяПродукцияDib { get; set; }
        public double ТмцОсновныеСредстваНП { get; set; }
        public double НалоговыеАктивы { get; set; }
        public double КзКлиента { get; set; }
        public double КзПоставщики { get; set; }
        public double КзЗп { get; set; }
        public double КзНалоги { get; set; }
        public double Ук { get; set; }
        public double Прибыль { get; set; }
        public double ДивидентыОбъекты { get; set; }
        public double Ниокр { get; set; }
        public double ИнвестииВКрупныеПроекты { get; set; }
        public double НераспределеннаяПрибыль { get; set; }
        public int Rec { get; set; }
    }
}
