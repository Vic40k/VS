using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ParamList
    {
        public int ParamId { get; set; }
        public int Type { get; set; }
        public int GroupId { get; set; }
        public int SubGroupId { get; set; }
        public int CategoryId { get; set; }
        public int EdIzmId { get; set; }
        public string Name { get; set; }
    }
}
