using AutoMapper;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Queries.Cllients;
using HotelComplex.DataAccess.Abstractions.Models;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Cllients;

public class GetClientQueryHandler
    : IRequestHandler<GetClientQuery, ClientDto>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GetClientQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<ClientDto> Handle(GetClientQuery request, CancellationToken cancellationToken)
    {
        var result = (await _unitOfWork
                .GetReadonlyRepository<Client>()
                .GetAsync(x =>x.Id == request.Id))
            .FirstOrDefault();

        return _mapper.Map<ClientDto>(result);
    }
}