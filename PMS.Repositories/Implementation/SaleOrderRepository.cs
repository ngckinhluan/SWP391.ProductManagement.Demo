using PMS.BusinessObjects.Context;
using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;

namespace PMS.Repositories.Implementation;

public class SaleOrderRepository : Repository<SaleOrder>, ISaleOrderRepository
{
    public SaleOrderRepository(MyDbContext context) : base(context)
    {
    }
    
}