using AutoMapper;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.DataAccess.Abstractions.Models;

namespace HotelComplex.Clients.Models.Profiles;

public class AddAccommodationProfile: Profile
{
    public AddAccommodationProfile()
    {
        CreateMap<AddAccomodationVm, AccommodationDto>().ReverseMap();
    }
}