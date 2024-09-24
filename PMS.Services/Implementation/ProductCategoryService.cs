using PMS.BusinessObjects.Entities;
using PMS.Services.Interface;

namespace PMS.Services.Implementation;

public class ProductCategoryService : IProductCategoryService
{
    public Task<IEnumerable<ProductCategory>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProductCategory?> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task InsertAsync(ProductCategory entity)
    {
        throw new NotImplementedException();
    }

    public void Update(ProductCategory entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(ProductCategory entity)
    {
        throw new NotImplementedException();
    }
}