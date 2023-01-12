using AutoMapper;
using DataAccess.Hotel.Abstractions.Models;

namespace HotelComplex.CQRS.Abstractions.Models.Profiles;

public class RoomProfile : Profile
{
    public RoomProfile()
    {
        CreateMap<RoomDto, Room>().ReverseMap();
    }
}