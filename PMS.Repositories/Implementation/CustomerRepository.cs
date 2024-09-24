using PMS.BusinessObjects.Context;
using PMS.BusinessObjects.Entities;
using PMS.Repositories.Interface;

namespace PMS.Repositories.Implementation;

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    public CustomerRepository(MyDbContext context) : base(context)
    {
    }
}