using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class CatMashObj
    {
        public int Idobj { get; set; }
        public string Nam { get; set; }
        public int Inv { get; set; }
        public int Idizgot { get; set; }
        public int Resurs { get; set; }
        public int Status { get; set; }
        public DateTime? Datavv { get; set; }
        public DateTime? Datavyv { get; set; }
        public int IdmainIzgot { get; set; }
        public int Ideq { get; set; }
    }
}
