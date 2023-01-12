using AutoMapper;
using DataAccess.Hotel.Abstractions.Models;
using HotelComplex.CQRS.Commands.Rooms;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Rooms;

public class DeleteRoomCommandHandler
    :  IRequestHandler<DeleteRoomCommand, bool>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteRoomCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork
            .GetReadWriteRepository<Room>()
            .RemoveAsync(request.Data);

        return true;
    }
}