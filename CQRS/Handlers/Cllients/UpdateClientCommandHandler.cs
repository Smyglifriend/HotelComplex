using AutoMapper;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Commands.Cllients;
using HotelComplex.DataAccess.Abstractions.Models;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Cllients;

public class UpdateClientCommandHandler
    : IRequestHandler<UpdateClientCommand, ClientDto>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateClientCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<ClientDto> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
    {
        var updatingModel = await _unitOfWork
            .GetReadWriteRepository<Client>()
            .UpdateAsync(_mapper.Map<Client>(request.Data));

        return _mapper.Map<ClientDto>(updatingModel);
    }
}