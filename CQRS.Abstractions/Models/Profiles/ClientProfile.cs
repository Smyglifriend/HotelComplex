using AutoMapper;
using DataAccess.Hotel.Abstractions.Models;
using HotelComplex.DataAccess.Abstractions.Models;

namespace HotelComplex.CQRS.Abstractions.Models.Profiles;

public class ClientProfile : Profile
{
    public ClientProfile()
    {
        CreateMap<ClientDto, Client>().ReverseMap();
    }
}