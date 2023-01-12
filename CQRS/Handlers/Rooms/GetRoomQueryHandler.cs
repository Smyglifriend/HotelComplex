using AutoMapper;
using DataAccess.Hotel.Abstractions.Models;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Queries.Rooms;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Rooms;

public class GetRoomQueryHandler
    : IRequestHandler<GetRoomQuery, RoomDto>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GetRoomQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<RoomDto> Handle(GetRoomQuery request, CancellationToken cancellationToken)
    {
        var result = (await _unitOfWork
            .GetReadonlyRepository<Room>()
            .GetAsync(x =>x.Id == request.Id))
            .FirstOrDefault();

        return _mapper.Map<RoomDto>(result);
    }
}