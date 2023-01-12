using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Commands.Rooms;
using MassTransit;
using MediatR;
using RabbitMQ.Events;

namespace RabbitMQ.Consumers.Consumers;

public class RoomRegisteredConsumer : IConsumer<RoomRegistered>
{
    private readonly IMediator _mediator;

    public RoomRegisteredConsumer(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task Consume(ConsumeContext<RoomRegistered> context)
    {
        await _mediator.Send(new UpdateRoomCommand
        {
            Data = new RoomDto
            {
                Id = context.Message.NumberRoom,
                IsBlocked = true
            }
        });
    }
}