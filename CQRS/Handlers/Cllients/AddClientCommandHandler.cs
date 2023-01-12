using AutoMapper;
using HotelComplex.CQRS.Commands.Cllients;
using HotelComplex.DataAccess.Abstractions.Models;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Cllients;

public class AddClientCommandHandler
    : IRequestHandler<AddClientCommand, long>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public AddClientCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<long> Handle(AddClientCommand request, CancellationToken cancellationToken)
    {
        return await _unitOfWork
            .GetReadWriteRepository<Client>()
            .SaveAsync(_mapper.Map<Client>(request.Data));
    }
}