using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class TbhPolls
    {
        public int PollId { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public string QuestionText { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsArchived { get; set; }
        public DateTime? ArchivedDate { get; set; }
    }
}
