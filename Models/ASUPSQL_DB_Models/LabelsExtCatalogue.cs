using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class LabelsExtCatalogue
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public byte Mark { get; set; }
        public byte[] LabelTemplate { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public byte QuantityPacks { get; set; }
        public decimal? WeightB { get; set; }
        public decimal? VolumeB { get; set; }
        public DateTime DateSave { get; set; }
        public string Name { get; set; }
        public string Ral { get; set; }
        public double? Height { get; set; }
        public double? HeightB { get; set; }
        public double? Width { get; set; }
        public double? WidthB { get; set; }
        public double? Depth { get; set; }
        public double? DepthB { get; set; }
        public string NameKz { get; set; }
        public string ClientCode { get; set; }
        public string DeliverySet { get; set; }
        public string DeliverySetKz { get; set; }
        public string DeclarationNumber { get; set; }
        public byte[] LabelTemplateB { get; set; }
    }
}
