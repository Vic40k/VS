using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class SpecificationNotice
    {
        public int Id { get; set; }
        public int Idspec { get; set; }
        public string Detail { get; set; }
        public byte NoticePositionType { get; set; }
        public string ChangeInfo { get; set; }
        public byte? StockCode { get; set; }
    }
}
