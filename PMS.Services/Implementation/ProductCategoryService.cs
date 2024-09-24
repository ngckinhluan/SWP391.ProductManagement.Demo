using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;
using PMS.Services.Interface;

namespace PMS.Services.Implementation;

public class ProductCategoryService : IProductCategoryService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductCategoryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<ProductCategory>> GetAllAsync() => await _unitOfWork.ProductCategories.GetAllAsync();
    public async Task<ProductCategory?> GetByIdAsync(string id) => await _unitOfWork.ProductCategories.GetByIdAsync(id);

    public async Task InsertAsync(ProductCategory entity)
    {
        await _unitOfWork.ProductCategories.InsertAsync(entity);
        await _unitOfWork.CompleteAsync();
    }


    public async void Update(ProductCategory entity)
    {
        _unitOfWork.ProductCategories.Update(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async void Delete(ProductCategory entity)
    {
        _unitOfWork.ProductCategories.Delete(entity);
        await _unitOfWork.CompleteAsync();
    }
}