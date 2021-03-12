using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ConfFormState
    {
        public int IdRec { get; set; }
        public int IdIzgot { get; set; }
        public DateTime Period { get; set; }
        public int Range { get; set; }
        public string FormName { get; set; }
        public int FormState { get; set; }
        public string Bai { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
