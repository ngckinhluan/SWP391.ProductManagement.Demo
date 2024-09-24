using PMS.BusinessObjects.Entities;

namespace PMS.Services.Interface;

public interface ISaleOrderService
{
    Task<IEnumerable<SaleOrder>> GetAllAsync();
    Task<SaleOrder?> GetByIdAsync(string id);
    Task InsertAsync(SaleOrder entity);
    void Update(SaleOrder entity);
    void Delete(SaleOrder entity);
}