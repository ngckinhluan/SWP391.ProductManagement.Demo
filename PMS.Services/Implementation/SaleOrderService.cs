using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;
using PMS.Services.Interface;

namespace PMS.Services.Implementation;

public class SaleOrderService : ISaleOrderService
{
    private readonly IUnitOfWork _unitOfWork;

    public SaleOrderService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<SaleOrder>> GetAllAsync() => await _unitOfWork.SaleOrders.GetAllAsync();
    public async Task<SaleOrder?> GetByIdAsync(string id) => await _unitOfWork.SaleOrders.GetByIdAsync(id);

    public async Task InsertAsync(SaleOrder entity)
    {
        await _unitOfWork.SaleOrders.InsertAsync(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async void Update(SaleOrder entity)
    {
        _unitOfWork.SaleOrders.Update(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async void Delete(SaleOrder entity)
    {
        _unitOfWork.SaleOrders.Delete(entity);
        await _unitOfWork.CompleteAsync();
    }
}