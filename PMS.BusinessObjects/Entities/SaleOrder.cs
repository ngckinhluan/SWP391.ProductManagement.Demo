using System;
using System.Collections.Generic;

namespace PMS.BusinessObjects.Entities;

public partial class SaleOrder
{
    public int SaleOrderId { get; set; }

    public int CustomerId { get; set; }

    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string? ShipAddress { get; set; }

    public DateTime? ShipDate { get; set; }

    public decimal SubAmount { get; set; }

    public decimal Vatrate { get; set; }

    public decimal Vatamount { get; set; }

    public decimal TotalAmount { get; set; }

    public int Status { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; } = new List<SaleOrderDetail>();
}
