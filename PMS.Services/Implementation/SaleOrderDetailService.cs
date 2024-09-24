using PMS.BusinessObjects.Entities;
using PMS.Services.Interface;

namespace PMS.Services.Implementation;

public class SaleOrderDetailService : ISaleOrderDetailService
{
    public Task<IEnumerable<SaleOrderDetail>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SaleOrderDetail?> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task InsertAsync(SaleOrderDetail entity)
    {
        throw new NotImplementedException();
    }

    public void Update(SaleOrderDetail entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(SaleOrderDetail entity)
    {
        throw new NotImplementedException();
    }
}