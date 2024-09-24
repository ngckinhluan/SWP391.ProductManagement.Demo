using System;
using System.Collections.Generic;

namespace PMS.BusinessObjects.Entities;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerCode { get; set; }

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string Email { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();
}
