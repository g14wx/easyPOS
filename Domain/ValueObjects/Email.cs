using EmailValidation;
using StocktakingDomain.Domain.Common;

namespace Domain.ValueObjects;
public record Email : IValueObject
{
    private Email(string value)
    {
        Value = value;
    }

    public string Value { get; init; }

    public bool Contains(string value)
    {
        return Value.Contains(value);
    }

    public static Email? Create(string value)
    {
        return EmailValidator.Validate(value) ? new Email(value.Trim()) : null;
    }
}
