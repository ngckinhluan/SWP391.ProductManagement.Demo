using System;
using System.Collections.Generic;

namespace PMS.BusinessObjects.Entities;

public partial class ProductCategory
{
    public int ProductCategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
