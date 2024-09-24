
using PMS.BusinessObjects.Entities;

namespace PMS.Services.Interface;

public interface ICustomerService
{
    Task<IEnumerable<Customer>> GetAllAsync();
    Task<Customer?> GetByIdAsync(string id);
    Task InsertAsync(Customer entity);
    void Update(Customer entity);
    void Delete(Customer entity);
}