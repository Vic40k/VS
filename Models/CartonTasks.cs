using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CartonTasks
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Smena { get; set; }
        public string Customer { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int Count { get; set; }
        public DateTime? AtTime { get; set; }
        public DateTime Created { get; set; }
    }
}
