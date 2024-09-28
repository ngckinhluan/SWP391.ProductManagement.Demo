using PMS.BusinessObjects.Exception.Base;

namespace PMS.BusinessObjects.Exception.Customer
{
    public sealed class CustomerNotFoundException : NotFoundException
    {
        public CustomerNotFoundException(string companyId) : base($"The customer with ${companyId} doesn't exist in database!")
        {
        }
    }
}
