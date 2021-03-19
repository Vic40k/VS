using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОсНоменклатура
    {
        public int Id { get; set; }
        public int GrInputId { get; set; }
        public int? PrixodRecordId { get; set; }
        public string Name { get; set; }
        public string InvNbr { get; set; }
        public string InvNbrOld { get; set; }
        public int? NodeId { get; set; }
        public DateTime? DateIn { get; set; }
        public string NbrDocIn { get; set; }
        public DateTime? DateDocIn { get; set; }
        public DateTime? DateUse { get; set; }
        public string NbrUse { get; set; }
        public DateTime? DateOut { get; set; }
        public string NbrOut { get; set; }
        public int? UsePeriod { get; set; }
        public int? AmorShifr { get; set; }
        public byte? TypeCalc { get; set; }
        public int? WorkYear { get; set; }
        public byte? Pdr { get; set; }
        public int? UrFaceId { get; set; }
        public int? Mol { get; set; }
        public string Place { get; set; }
        public string Post { get; set; }
        public string Manufactor { get; set; }
        public DateTime? DateManufactory { get; set; }
        public string FactoryNbr { get; set; }
        public int IdEdIzm { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? LastEditDate { get; set; }
        public int? LastEditUserId { get; set; }
        public byte? AmorGroup { get; set; }
        public int? AmorCategory { get; set; }
        public string Description { get; set; }
    }
}
