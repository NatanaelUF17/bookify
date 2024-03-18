namespace Bookify.Domain.Records;

public record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    String Street
);