using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechInstructionsNotices
    {
        public int Id { get; set; }
        public int Idinstr { get; set; }
        public string NumberNotice { get; set; }
        public string NameInstr { get; set; }
        public string ProductionNames { get; set; }
        public int? Cell { get; set; }
        public byte[] FileInstr { get; set; }
        public string FileInstrExtension { get; set; }
        public DateTime? DateDevelopmentStart { get; set; }
        public string NoticeReason { get; set; }
        public string NoticeDescription { get; set; }
        public bool Agreement1 { get; set; }
        public DateTime? DateAgreement1 { get; set; }
        public int? IdpersonAgreement1 { get; set; }
        public bool Agreement2 { get; set; }
        public DateTime? DateAgreement2 { get; set; }
        public int? IdpersonAgreement2 { get; set; }
        public bool Agreement3 { get; set; }
        public DateTime? DateAgreement3 { get; set; }
        public int? IdpersonAgreement3 { get; set; }
        public bool Agreement4 { get; set; }
        public DateTime? DateAgreement4 { get; set; }
        public int? IdpersonAgreement4 { get; set; }
        public bool Agreement5 { get; set; }
        public DateTime? DateAgreement5 { get; set; }
        public int? IdpersonAgreement5 { get; set; }
        public bool? DevelopmentFinish { get; set; }
        public DateTime? DateDevelopmentFinish { get; set; }
        public bool Launched { get; set; }
        public DateTime? DateLaunch { get; set; }
    }
}
