using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class SpecificationOperationsLog
    {
        public int Id { get; set; }
        public int Idspec { get; set; }
        public string Node { get; set; }
        public string Detail { get; set; }
        public byte OperationType { get; set; }
        public byte ParameterType { get; set; }
        public string ParameterValueWas { get; set; }
        public string ParameterValueIs { get; set; }
        public DateTime? DateOperation { get; set; }
    }
}
