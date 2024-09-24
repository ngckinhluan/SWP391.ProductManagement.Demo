using PMS.BusinessObjects.Entities;

namespace PMS.Services.Interface;

public interface IProductCategoryService
{
    Task<IEnumerable<ProductCategory>> GetAllAsync();
    Task<ProductCategory?> GetByIdAsync(string id);
    Task InsertAsync(ProductCategory entity);
    void Update(ProductCategory entity);
    void Delete(ProductCategory entity);
    
}