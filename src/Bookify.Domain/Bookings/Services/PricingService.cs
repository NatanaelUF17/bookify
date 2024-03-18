﻿using Bookify.Domain.Apartments;
using Bookify.Domain.Apartments.Records;
using Bookify.Domain.Bookings.Records;
using Bookify.Domain.Apartments.Enums;

namespace Bookify.Domain.Bookings.Services;

public class PricingService
{
	public PricingDetails = CalculatePrice(Apartment apartment, DateRange period)
	{
		var currency = apartment.Price.Currency;

		var priceForPeriod = new Money(apartment.Price.Amount * period.LengthInDays, currency);

		decimal pertentageUpCharge = 0;

		foreach (var amenity in apartment.Amenities)
		{
			pertentageUpCharge += amenity switch
			{
				Amenity.GardenView or Amenity.MountainView => 0.05m,
				Amenity.AirConditioning => 0.01m,
				Amenity.Parking => 0.01m,
				_ => 0
			};
		}

		var amenitiesUpCharge = Money.Zero();
		if (pertentageUpCharge > 0)
		{
			amenitiesUpCharge = new Money(priceForPeriod.Amount * pertentageUpCharge, currency);
		}
	}
}