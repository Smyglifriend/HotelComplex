using HotelComplex.CQRS.Abstractions;
using MediatR;

namespace HotelComplex.CQRS.Commands.Cllients;

public class DeleteClientCommand: ICommand<long>, IRequest<bool>
{
    public long Data { get; set; }
}