using System;
using System.Collections.Generic;

namespace PMS.BusinessObjects.Entities;

public partial class SaleOrderDetail
{
    public int SaleOrderDetailId { get; set; }

    public int? SaleOrderId { get; set; }

    public int? ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal? Discount { get; set; }

    public decimal Amount { get; set; }

    public string? Note { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Product? Product { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }
}
