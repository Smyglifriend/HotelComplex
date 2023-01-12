using HotelComplex.CQRS.Abstractions;
using HotelComplex.CQRS.Abstractions.Models;
using MediatR;

namespace HotelComplex.CQRS.Commands.Cllients;

public class UpdateClientCommand: ICommand<ClientDto>, IRequest<ClientDto>
{
    public ClientDto Data { get; set; }
}