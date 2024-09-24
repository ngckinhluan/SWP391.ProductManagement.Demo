using System;
using System.Collections.Generic;

namespace PMS.BusinessObjects.Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public int? ProductCategoryId { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? Color { get; set; }

    public double? Weight { get; set; }

    public string? UnitWeight { get; set; }

    public string? Size { get; set; }

    public string? Origin { get; set; }

    public decimal? ListPrice { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? Description { get; set; }

    public string? Note { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ProductCategory? ProductCategory { get; set; }

    public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; } = new List<SaleOrderDetail>();
}
