using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОсMenu
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string NameMenu { get; set; }
        public string ToolTip { get; set; }
        public string NameMenuA { get; set; }
        public string ToolTipA { get; set; }
        public byte CommandType { get; set; }
        public string CommandName { get; set; }
        public byte TypeId { get; set; }
        public byte StyleId { get; set; }
        public byte? SortOrder { get; set; }
    }
}
