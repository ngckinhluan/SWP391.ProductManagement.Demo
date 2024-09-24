using PMS.BusinessObjects.Context;
using PMS.Repositories.Interface;

namespace PMS.Repositories.Implementation;

public class UnitOfWork : IUnitOfWork
{
    private readonly MyDbContext _context;
    public IProductRepository Products { get; }
    public ICustomerRepository Customers { get; }
    public ISaleOrderRepository SaleOrders { get; }
    
    public IProductRepository ProductRepository { get; }
    public IProductCategoryRepository ProductCategories { get; }
    public ISaleOrderDetailRepository SaleOrderDetailRepository { get; }

    public UnitOfWork(MyDbContext context, IProductRepository productRepository, ICustomerRepository customerRepository,
        ISaleOrderRepository saleOrderRepository, IProductCategoryRepository productCategoryRepository, ISaleOrderDetailRepository saleOrderDetailRepository)
    {
        _context = context;
        Products = productRepository;
        Customers = customerRepository;
        SaleOrders = saleOrderRepository;
        ProductCategories = productCategoryRepository;
        SaleOrderDetailRepository = saleOrderDetailRepository;
    }

    public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

    public void Dispose() => _context.Dispose();

}