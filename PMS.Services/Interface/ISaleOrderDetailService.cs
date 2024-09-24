using PMS.BusinessObjects.Entities;

namespace PMS.Services.Interface;

public interface ISaleOrderDetailService
{
    Task<IEnumerable<SaleOrderDetail>> GetAllAsync();
    Task<SaleOrderDetail?> GetByIdAsync(string id);
    Task InsertAsync(SaleOrderDetail entity);
    void Update(SaleOrderDetail entity);
    void Delete(SaleOrderDetail entity);
    
}