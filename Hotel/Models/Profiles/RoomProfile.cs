using AutoMapper;
using HotelComplex.CQRS.Abstractions.Models;

namespace HotelComplex.Hotel.Models.Profiles;

public class RoomProfile: Profile
{
    public RoomProfile()
    {
        CreateMap<RoomVm, RoomDto>().ReverseMap();
    }
}