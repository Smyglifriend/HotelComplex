using AutoMapper;
using HotelComplex.CQRS.Commands.Accommodations;
using HotelComplex.CQRS.Commands.Cllients;
using HotelComplex.DataAccess.Abstractions.Models;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MassTransit;
using MediatR;
using RabbitMQ.Events;

namespace HotelComplex.CQRS.Handlers.Accommodations;

public class AddAccommodationForClientCommandHandler
    : IRequestHandler<AddAccommodationForClientCommand, long>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPublishEndpoint _publishEndpoint;

    public AddAccommodationForClientCommandHandler(
        IMapper mapper,
        IUnitOfWork unitOfWork,
        IPublishEndpoint publishEndpoint)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _publishEndpoint = publishEndpoint;
    }

    public async Task<long> Handle(AddAccommodationForClientCommand request, CancellationToken cancellationToken)
    {
        if (request.Data.RoomNumber > 0)
        {
            await _publishEndpoint.Publish(new RoomRegistered
                {
                    NumberRoom = request.Data.RoomNumber
                }, cancellationToken);
        }

        return await _unitOfWork
            .GetReadWriteRepository<Accommodation>()
            .SaveAsync(_mapper.Map<Accommodation>(request.Data));
    }
}