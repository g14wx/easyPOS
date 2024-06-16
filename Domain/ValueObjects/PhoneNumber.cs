using com.google.i18n.phonenumbers;

namespace Domain.ValueObjects;
public record PhoneNumber
{
    private PhoneNumber(string value)
    {
        Value = value;
    }

    public string Value { get; init; }

    public static PhoneNumber? Create(string value)
    {
        const string countryCode = "US";
        var phoneUtil = PhoneNumberUtil.getInstance();
        var phoneNumber = phoneUtil.parse(value.Trim(), countryCode);

        try
        {
            return phoneUtil.isValidNumber(phoneNumber) ? new PhoneNumber(value.Trim()) : null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
}