using AutoMapper;
using DataAccess.Hotel.Abstractions.Models;
using HotelComplex.CQRS.Commands.Rooms;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Rooms;

public class AddRoomCommandHandler
    : IRequestHandler<AddRoomCommand, long>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public AddRoomCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<long> Handle(AddRoomCommand request, CancellationToken cancellationToken)
    {
        return await _unitOfWork
            .GetReadWriteRepository<Room>()
            .SaveAsync(_mapper.Map<Room>(request.Data));
    }
}