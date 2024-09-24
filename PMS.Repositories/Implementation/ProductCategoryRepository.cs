using PMS.BusinessObjects.Context;
using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;

namespace PMS.Repositories.Implementation;

public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
{
    public ProductCategoryRepository(MyDbContext context) : base(context)
    {
    }
}