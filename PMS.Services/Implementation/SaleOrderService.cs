using PMS.BusinessObjects.Entities;
using PMS.Services.Interface;

namespace PMS.Services.Implementation;

public class SaleOrderService : ISaleOrderService
{
    public Task<IEnumerable<SaleOrder>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SaleOrder?> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task InsertAsync(SaleOrder entity)
    {
        throw new NotImplementedException();
    }

    public void Update(SaleOrder entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(SaleOrder entity)
    {
        throw new NotImplementedException();
    }
}