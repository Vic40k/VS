using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокСкладовПоставкиЗмк
    {
        public int IdСклада { get; set; }
        public string Наименование { get; set; }
        public string Индекс { get; set; }
        public int? IdГорода { get; set; }
        public string Группа { get; set; }
        public byte ТипСклада { get; set; }
        public string Примечание { get; set; }
        public int? IdДилера { get; set; }
        public bool Deleted { get; set; }
        public string ИндексПочт { get; set; }
        public int? IdГородаПочт { get; set; }
        public string УлицаДомПочт { get; set; }
        public string КодСклада { get; set; }
        public int FactoryId { get; set; }
        public int? IsMeteks { get; set; }
        public int FirmIdUserSklad { get; set; }
        public int? Report94 { get; set; }
        public int? Прогноз { get; set; }
        public int? ДляКарточкиЭксплуатации { get; set; }
        public int? Report21 { get; set; }
        public string TovDirection { get; set; }
    }
}
