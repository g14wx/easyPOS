using Domain.Primitives;
using Domain.ValueObjects;
using PhoneNumber = libphonenumber.PhoneNumber;

namespace Domain.Customers;

public sealed class Customer: AggregateRoot
{
    public Customer(CustomerId id, string name, string lastName, Email email, PhoneNumber phoneNumber, Address address)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
    }

    private Customer(Address address)
    {
        Address = address;
    }
    
    public CustomerId Id { get; private set; }
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public Email Email { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }
    public Address Address { get; private set; }
    
    public string FullName => $"{Name} {LastName}";
}