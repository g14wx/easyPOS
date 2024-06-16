namespace StocktakingDomain.Domain.Common;

public interface IValueObject
{
    public string Value { get; init; }

    public bool Contains(string value);
}