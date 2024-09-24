using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;
using PMS.Services.Interface;

namespace PMS.Services.Implementation;

public class SaleOrderDetailService : ISaleOrderDetailService
{
    private readonly IUnitOfWork _unitOfWork;
    public SaleOrderDetailService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<IEnumerable<SaleOrderDetail>> GetAllAsync() => await _unitOfWork.SaleOrderDetailRepository.GetAllAsync();
    public async Task<SaleOrderDetail?> GetByIdAsync(string id) =>
        await _unitOfWork.SaleOrderDetailRepository.GetByIdAsync(id);
   

    public async Task InsertAsync(SaleOrderDetail entity)
    {
        await _unitOfWork.SaleOrderDetailRepository.InsertAsync(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async void Update(SaleOrderDetail entity)
    {
         _unitOfWork.SaleOrderDetailRepository.Update(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async void Delete(SaleOrderDetail entity)
    {
        _unitOfWork.SaleOrderDetailRepository.Delete(entity);
        await _unitOfWork.CompleteAsync();
    }
}