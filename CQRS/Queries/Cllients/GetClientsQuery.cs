using HotelComplex.CQRS.Abstractions;
using HotelComplex.CQRS.Abstractions.Models;
using MediatR;

namespace HotelComplex.CQRS.Queries.Cllients;

public class GetClientsQuery: IQuery, IRequest<IEnumerable<ClientDto>>
{
    public long Id { get; set; }
}