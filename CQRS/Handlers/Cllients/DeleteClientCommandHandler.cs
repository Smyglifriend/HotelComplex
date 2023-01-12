using AutoMapper;
using HotelComplex.CQRS.Commands.Cllients;
using HotelComplex.DataAccess.Abstractions.Models;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using MediatR;

namespace HotelComplex.CQRS.Handlers.Cllients;

public class DeleteClientCommandHandler
    : IRequestHandler<DeleteClientCommand, bool>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteClientCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork
            .GetReadWriteRepository<Client>()
            .RemoveAsync(request.Data);

        return true;
    }
}