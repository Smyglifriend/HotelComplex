using HotelComplex.CQRS.Abstractions;
using HotelComplex.CQRS.Abstractions.Models;
using MediatR;

namespace HotelComplex.CQRS.Queries.Rooms;

public class GetRoomQuery: IQuery, IRequest<RoomDto>
{
    public long Id { get; set; }
}