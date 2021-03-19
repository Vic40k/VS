using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЦеныПоДилерамНовРегион
    {
        public int RecordId { get; set; }
        public int IdДилера { get; set; }
        public int IdТовара { get; set; }
        public double ЦенаСНдс { get; set; }
        public int Регион { get; set; }
        public double ЦенаСНдсМ { get; set; }
        public double ЦенаСНдсР { get; set; }
        public double ЦенаСНдсВ { get; set; }
        public double ЦенаСНдсЮг { get; set; }
        public double ЦенаСНдсПу { get; set; }
        public double ЦенаСНдсСз { get; set; }
        public double ЦенаСНдсСб { get; set; }
        public double ЦенаСНдсКкб { get; set; }
        public double ЦенаСНдсМА { get; set; }
        public double ЦенаСНдсЮгА { get; set; }
        public double ЦенаСНдсПуА { get; set; }
        public double ЦенаСНдсСзА { get; set; }
        public double ЦенаСНдсСбА { get; set; }
    }
}
