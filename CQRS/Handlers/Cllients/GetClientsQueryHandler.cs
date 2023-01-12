using AutoMapper;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Queries.Cllients;
using HotelComplex.DataAccess.Abstractions.Models;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Cllients;

public class GetClientsQueryHandler
    : IRequestHandler<GetClientsQuery, IEnumerable<ClientDto>>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GetClientsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<ClientDto>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork
            .GetReadonlyRepository<Client>()
            .GetAsync();

        return _mapper.Map<IEnumerable<ClientDto>>(result);
    }
}