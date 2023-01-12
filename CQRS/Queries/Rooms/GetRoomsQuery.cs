using HotelComplex.CQRS.Abstractions;
using HotelComplex.CQRS.Abstractions.Models;
using MediatR;

namespace HotelComplex.CQRS.Queries.Rooms;

public class GetRoomsQuery : IQuery, IRequest<IEnumerable<RoomDto>>
{
    public long Id { get; set; }
}