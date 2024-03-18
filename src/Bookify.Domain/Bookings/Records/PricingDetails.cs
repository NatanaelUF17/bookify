using Bookify.Domain.Apartments.Records;

namespace Bookify.Domain.Bookings.Records;

public record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice
);