using HotelComplex.CQRS.Abstractions;
using MediatR;

namespace HotelComplex.CQRS.Commands.Rooms;

public class DeleteRoomCommand: ICommand<long>, IRequest<bool>
{
    public long Data { get; set; }
}