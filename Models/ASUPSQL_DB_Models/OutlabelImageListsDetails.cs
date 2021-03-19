using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class OutlabelImageListsDetails
    {
        public int ImageId { get; set; }
        public int ImageListId { get; set; }
        public byte[] BinaryData { get; set; }
        public string Name { get; set; }
        public string ParamValue { get; set; }
        public string SignLinkPropertyId { get; set; }

        public virtual OutlabelImageLists ImageList { get; set; }
    }
}
