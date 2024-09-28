
using PMS.BusinessObjects.Entities;
using PMS.Shared.DTO.Customer;

namespace PMS.Services.Interface;

public interface ICustomerService
{
    Task<IEnumerable<CustomerDto>> GetAllAsync();
    CustomerDto GetByIdAsync(string id);
    CustomerDto InsertAsync(CustomerForCreationDto customerForCreationDto);
    void Update(string id, CustomerForUpdateDto customerForUpdateDto);
    void Delete(string id);
}