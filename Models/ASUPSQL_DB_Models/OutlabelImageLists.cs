using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class OutlabelImageLists
    {
        public OutlabelImageLists()
        {
            OutlabelImageListsDetails = new HashSet<OutlabelImageListsDetails>();
        }

        public int ImageListId { get; set; }
        public string Name { get; set; }
        public string ParamId { get; set; }

        public virtual OutlabelParams Param { get; set; }
        public virtual ICollection<OutlabelImageListsDetails> OutlabelImageListsDetails { get; set; }
    }
}
