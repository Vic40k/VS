﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class AspnetWebEventEvents
    {
        public string EventId { get; set; }
        public DateTime EventTimeUtc { get; set; }
        public DateTime EventTime { get; set; }
        public string EventType { get; set; }
        public decimal EventSequence { get; set; }
        public decimal EventOccurrence { get; set; }
        public int EventCode { get; set; }
        public int EventDetailCode { get; set; }
        public string Message { get; set; }
        public string ApplicationPath { get; set; }
        public string ApplicationVirtualPath { get; set; }
        public string MachineName { get; set; }
        public string RequestUrl { get; set; }
        public string ExceptionType { get; set; }
        public string Details { get; set; }
    }
}
