namespace Bookify.Domain.Records;

public record Currency
{
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Dop = new("DOP");
    internal static readonly Currency None = new("");
    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        Usd,
        Dop
    };

    public string Code { get; init; }

    private Currency(string code) => Code = code;

    public static Currency FromCode(string code)
    {
        return All
            .FirstOrDefault(x => x.Code == code) ?? throw new ApplicationException("The currency code is invalid.");
    }
}