using AutoMapper;
using HotelComplex.DataAccess.Abstractions.Models;

namespace HotelComplex.CQRS.Abstractions.Models.Profiles;

public class AccommodationProfile: Profile
{
    public AccommodationProfile()
    {
        CreateMap<AccommodationDto, Accommodation>().ReverseMap();
    }
}