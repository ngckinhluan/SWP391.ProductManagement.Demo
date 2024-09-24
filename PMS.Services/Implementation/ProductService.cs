using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;
using PMS.Services.Interface;

namespace PMS.Services.Implementation;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Product>> GetAllAsync() => await _unitOfWork.Products.GetAllAsync();

    public async Task<Product?> GetByIdAsync(string id) => await _unitOfWork.Products.GetByIdAsync(id);

    public async Task InsertAsync(Product entity)
    {
        await _unitOfWork.Products.InsertAsync(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async void Update(Product entity)
    {
        _unitOfWork.Products.Update(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async void Delete(Product entity)
    {
        _unitOfWork.Products.Delete(entity);
        await _unitOfWork.CompleteAsync();
    }
}