namespace PMS.Repositories.Interface;

public interface IUnitOfWork
{
    IProductRepository Products { get; }
    ICustomerRepository Customers { get; }
    ISaleOrderRepository SaleOrders { get; }
    IProductRepository ProductRepository { get; }
    IProductCategoryRepository ProductCategories { get; }
    
    Task<int> CompleteAsync();
    void Dispose();
}