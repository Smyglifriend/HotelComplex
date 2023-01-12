using HotelComplex.CQRS.Abstractions;
using HotelComplex.CQRS.Abstractions.Models;
using MediatR;

namespace HotelComplex.CQRS.Commands.Cllients;

public class AddClientCommand : ICommand<ClientDto>, IRequest<long>
{
    public ClientDto Data { get; set; }
}