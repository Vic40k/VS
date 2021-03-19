using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TasksAndMessages
    {
        public int Id { get; set; }
        public int Author { get; set; }
        public int? ToUserId { get; set; }
        public string ToUserGroup { get; set; }
        public int Type { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Done { get; set; }
        public DateTime? UntilDate { get; set; }
        public string Message { get; set; }
        public int? Status { get; set; }
    }
}
