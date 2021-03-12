using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ToCustomerContact
    {
        public int Id { get; set; }
        public int IdBranch { get; set; }
        public int Hid { get; set; }
        public DateTime? Birthday { get; set; }
        public string Companies { get; set; }
        public string CompanyName { get; set; }
        public string Email1Address { get; set; }
        public string Email2Address { get; set; }
        public string Email3Address { get; set; }
        public string Email1AddressType { get; set; }
        public string Email2AddressType { get; set; }
        public string Email3AddressType { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string BusinessTelephoneNumber { get; set; }
        public string HomeTelephoneNumber { get; set; }
        public string MobileTelephoneNumber { get; set; }
        public string OtherTelephoneNumber { get; set; }
        public string WebPage { get; set; }
    }
}
