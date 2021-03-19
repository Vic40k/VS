using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ToCustomerAppointment
    {
        public int Id { get; set; }
        public int IdBranch { get; set; }
        public int Hid { get; set; }
        public string Body { get; set; }
        public string Companies { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? End { get; set; }
        public DateTime? Start { get; set; }
        public string EntryId { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Organizer { get; set; }
        public string RequiredAttendees { get; set; }
    }
}
