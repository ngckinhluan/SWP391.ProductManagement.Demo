using AutoMapper;
using PMS.BusinessObjects.Entities;
using PMS.BusinessObjects.Exception.Customer;
using PMS.Repositories.Interface;
using PMS.Services.Interface;
using PMS.Shared.DTO.Customer;

namespace PMS.Services.Implementation;

public class CustomerService : ICustomerService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task<IEnumerable<CustomerDto>> GetAllAsync()
    {
        _unitOfWork.BeginTransaction();
        try
        {
            var customers = await _unitOfWork.Customers.GetAllAsync();
            if (customers is null)
            {
                _unitOfWork.RollBack();
                throw new NoCustomersFoundException();
            }
            var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);
            _unitOfWork.CommitTransaction();
            return customersDto;
        }
        catch (Exception e)
        {
            _unitOfWork.RollBack();
            throw new Exception(e.Message);
        }

    }

    public CustomerDto GetByIdAsync(string id)
    {
        _unitOfWork.BeginTransaction();
        try
        {
            var customer = _unitOfWork.Customers.GetByIdAsync(id);
            if (customer is null)
            {
                _unitOfWork.RollBack();
                throw new CustomerNotFoundException(id);
            }
            var customerDto = _mapper.Map<CustomerDto>(customer);
            _unitOfWork.CommitTransaction();
            return customerDto;
        }
        catch (Exception e)
        {
            _unitOfWork.RollBack();
            throw new Exception(e.Message);
        }
    }


    public CustomerDto InsertAsync(CustomerForCreationDto customerForCreationDto)
    {
        var customerEntity = _mapper.Map<Customer>(customerForCreationDto);
        _unitOfWork.BeginTransaction();
        try
        {
            _unitOfWork.Customers.InsertAsync(customerEntity);
            _unitOfWork.CompleteAsync();
            var customerDto = _mapper.Map<CustomerDto>(customerEntity);
            _unitOfWork.CommitTransaction();
            return customerDto;
        }
        catch (Exception e)
        {
            _unitOfWork.RollBack();
            throw new Exception(e.Message);
        }
    }

    public void Update(string id, CustomerForUpdateDto customerForUpdateDto)
    {
        var customerEntity = _mapper.Map<Customer>(customerForUpdateDto);
        _unitOfWork.BeginTransaction();
        try
        {
            _unitOfWork.Customers.Update(customerEntity);
            _unitOfWork.CompleteAsync();
            _unitOfWork.CommitTransaction();
        }
        catch (Exception e)
        {
            _unitOfWork.RollBack();
            throw new Exception(e.Message);
        }
    }

    public async void Delete(string id)
    {
        _unitOfWork.BeginTransaction();
        try
        {
            var customer = await _unitOfWork.Customers.GetByIdAsync(id);
            if (customer is null)
            {
                _unitOfWork.RollBack();
                throw new CustomerNotFoundException(id);
            }
            _unitOfWork.Customers.Delete(customer);
            await _unitOfWork.CompleteAsync();
            _unitOfWork.CommitTransaction();
        }
        catch (Exception e)
        {
            _unitOfWork.RollBack();
            throw new Exception(e.Message);
        }
    }
}