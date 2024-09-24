using PMS.BusinessObjects.Context;
using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;

namespace PMS.Repositories.Implementation;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(MyDbContext context) : base(context)
    {
    }

   
}