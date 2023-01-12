using AutoMapper;
using HotelComplex.Clients.Models;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Commands.Accommodations;
using HotelComplex.CQRS.Commands.Cllients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelComplex.Clients.Controllers;

[ApiController]
[Route("api/accommodations")]
public class AccommodationController: ControllerBase
{
    private IMediator _mediator;
    private IMapper _mapper;

    public AccommodationController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<long>> Post([FromBody] AddAccomodationVm model)
    {
        var result = await _mediator.Send(new AddAccommodationForClientCommand
        {
            Data = _mapper.Map<AccommodationDto>(model)
        });

        return Ok(result);
    }
}