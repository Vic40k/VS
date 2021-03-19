﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокРазрешений
    {
        public int IdРазрешения { get; set; }
        public int IdДилера { get; set; }
        public int UserId { get; set; }
        public DateTime Дата { get; set; }
        public string Причина { get; set; }
        public int? Номер { get; set; }
    }
}
