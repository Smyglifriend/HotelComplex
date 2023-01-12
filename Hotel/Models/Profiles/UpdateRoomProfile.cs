using AutoMapper;
using HotelComplex.CQRS.Abstractions.Models;

namespace HotelComplex.Hotel.Models.Profiles;

public class UpdateRoomProfile : Profile
{
    public UpdateRoomProfile()
    {
        CreateMap<UpdateRoomVm, RoomDto>().ReverseMap();
    }
}