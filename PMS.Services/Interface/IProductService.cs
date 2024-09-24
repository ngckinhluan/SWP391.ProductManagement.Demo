using PMS.BusinessObjects.Entities;

namespace PMS.Services.Interface;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(string id);
    Task InsertAsync(Product entity);
    void Update(Product entity);
    void Delete(Product entity);
}