using HotelComplex.CQRS.Abstractions;
using HotelComplex.CQRS.Abstractions.Models;
using MediatR;

namespace HotelComplex.CQRS.Commands.Rooms;

public class UpdateRoomCommand: ICommand<RoomDto>, IRequest<RoomDto>
{
    public RoomDto Data { get; set; }
}