using AutoMapper;
using DataAccess.Hotel.Abstractions.Models;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Commands.Rooms;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Rooms;

public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, RoomDto>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateRoomCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<RoomDto> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
    {
        var updatingModel = await _unitOfWork
            .GetReadWriteRepository<Room>()
            .UpdateAsync(_mapper.Map<Room>(request.Data));

        return _mapper.Map<RoomDto>(updatingModel);
    }
}