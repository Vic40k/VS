﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ДокументыEcbs
    {
        public int Id { get; set; }
        public byte[] BinaryData { get; set; }
        public string Description { get; set; }
        public string FileExtention { get; set; }
    }
}
