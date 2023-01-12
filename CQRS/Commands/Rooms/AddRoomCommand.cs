using HotelComplex.CQRS.Abstractions;
using HotelComplex.CQRS.Abstractions.Models;
using MediatR;

namespace HotelComplex.CQRS.Commands.Rooms;

public class AddRoomCommand: ICommand<RoomDto>, IRequest<long>
{
    public RoomDto Data { get; set; }
}