using HotelComplex.CQRS.Abstractions;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.DataAccess.Abstractions.Models;
using MediatR;

namespace HotelComplex.CQRS.Commands.Accommodations;

public class AddAccommodationForClientCommand: ICommand<AccommodationDto>, IRequest<long>
{
    public AccommodationDto Data { get; set; }
}