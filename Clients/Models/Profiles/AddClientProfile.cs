using AutoMapper;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.DataAccess.Abstractions.Models;

namespace HotelComplex.Clients.Models.Profiles;

public class AddClientProfile: Profile
{
    public AddClientProfile()
    {
        CreateMap<AddClientVm, ClientDto>().ReverseMap();
    }
}