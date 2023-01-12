using AutoMapper;
using DataAccess.Hotel.Abstractions.Models;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Queries.Rooms;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Rooms;

public class GetRoomsQueryHandler 
    : IRequestHandler<GetRoomsQuery, IEnumerable<RoomDto>>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GetRoomsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<RoomDto>> Handle(GetRoomsQuery request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork
            .GetReadonlyRepository<Room>()
            .GetAsync();

        return _mapper.Map<IEnumerable<RoomDto>>(result);
    }
}