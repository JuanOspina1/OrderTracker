using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Customer>> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }
    }
}