using PMS.BusinessObjects.Context;
using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;

namespace PMS.Repositories.Implementation;

public class SaleOrderDetailRepository : Repository<SaleOrderDetail>, ISaleOrderDetailRepository
{
    public SaleOrderDetailRepository(MyDbContext context) : base(context)
    {
    }
}