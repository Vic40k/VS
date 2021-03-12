using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ToolsPy
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public byte[] DocumentFile { get; set; }
        public DateTime? DateChange { get; set; }
        public int? UserId { get; set; }
        public string DocumentFileExtention { get; set; }
        public int Unit { get; set; }
        public int Status { get; set; }
        public string Cell { get; set; }
        public byte[] ScanStudy { get; set; }
        public string ScanStudyFileExtention { get; set; }
        public int UnitNow { get; set; }
        public DateTime? DateDevelopment { get; set; }
        public DateTime? DateLaunch { get; set; }
        public byte MethodOrCase { get; set; }
        public int? ProductionType { get; set; }
        public bool DevelopedView { get; set; }
    }
}
