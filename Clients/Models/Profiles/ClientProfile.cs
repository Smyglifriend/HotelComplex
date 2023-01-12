using AutoMapper;
using HotelComplex.CQRS.Abstractions.Models;

namespace HotelComplex.Clients.Models.Profiles;

public class ClientProfile: Profile
{
    public ClientProfile()
    {
        CreateMap<ClientVm, ClientDto>().ReverseMap();
    }
}