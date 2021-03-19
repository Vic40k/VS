using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПроизводственнаяСтруктураCopy
    {
        public int Id { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string FullPath { get; set; }
        public int? NodeLevel { get; set; }
        public int? Директор { get; set; }
        public int? Юрлицо { get; set; }
        public int? Технолог { get; set; }
        public int? Руководитель { get; set; }
        public int? HidДиректор { get; set; }
        public int? HidТехнолог { get; set; }
        public int? HidРуководитель { get; set; }
        public int? IdДиректор1 { get; set; }
        public int? IdТехнолог1 { get; set; }
        public int? IdРуководитель1 { get; set; }
        public int? Регион { get; set; }
        public string Код { get; set; }
    }
}
