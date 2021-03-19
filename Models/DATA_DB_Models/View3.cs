using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class View3
    {
        public int ProductId { get; set; }
        public string AddedDate { get; set; }
        public int AddedBy { get; set; }
        public int? DepartmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Sku111 { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? DiscountPercentage { get; set; }
        public string UnitsInStock { get; set; }
        public int SmallImageUrl { get; set; }
        public int FullImageUrl { get; set; }
        public int Votes { get; set; }
        public int? TotalRating { get; set; }
        public string DepartmentTitle { get; set; }
        public int? Sku { get; set; }
        public long? RowNum { get; set; }
    }
}
