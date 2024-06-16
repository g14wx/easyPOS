namespace Domain.Customers.Repository;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId id);
    Task<Customer?> AddAsync(Customer customer);
}