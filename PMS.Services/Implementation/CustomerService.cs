using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;
using PMS.Services.Interface;

namespace PMS.Services.Implementation;

public class CustomerService : ICustomerService
{
    private readonly IUnitOfWork _unitOfWork;

    public CustomerService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<Customer>> GetAllAsync() => await _unitOfWork.Customers.GetAllAsync();

    public async Task<Customer?> GetByIdAsync(string id) => await  _unitOfWork.Customers.GetByIdAsync(id);

    public async Task InsertAsync(Customer entity)
    {
        await _unitOfWork.Customers.InsertAsync(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async void Update(Customer entity)
    {
        _unitOfWork.Customers.Update(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async void Delete(Customer entity)
    {
      _unitOfWork.Customers.Delete(entity);
      await _unitOfWork.CompleteAsync();
    }
}