using Core.Entities;

namespace Core.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<IReadOnlyList<Customer>> GetCustomersAsync();
    }
}