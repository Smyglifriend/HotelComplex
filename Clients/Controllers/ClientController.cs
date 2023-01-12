using AutoMapper;
using HotelComplex.Clients.Models;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Commands.Accommodations;
using HotelComplex.CQRS.Commands.Cllients;
using HotelComplex.CQRS.Queries.Cllients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelComplex.Clients.Controllers;

[ApiController]
[Route("api/clients")]
public class ClientController : ControllerBase
{
    private IMediator _mediator;
    private IMapper _mapper;

    public ClientController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IEnumerable<ClientVm>> Get()
        => _mapper.Map<IEnumerable<ClientVm>>(
            await _mediator.Send(new GetClientsQuery()));

    [HttpGet("{id}")]
    public async Task<ClientVm> Get(long id)
        => _mapper.Map<ClientVm>(
            await _mediator.Send(new GetClientQuery
            {
                Id = id
            }));

    [HttpPost]
    public async Task<ActionResult<long>> Post([FromBody] AddClientVm model)
    {
        var clientId = await _mediator.Send(new AddClientCommand
        {
            Data = _mapper.Map<ClientDto>(model)
        });

        return Ok(clientId);
    }

    [HttpPut]
    public async Task<ActionResult<ClientVm>> Put([FromBody] ClientVm model)
        => Ok(await _mediator.Send(new UpdateClientCommand
        {
            Data = _mapper.Map<ClientDto>(model)
        }));

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(long id)
        => Ok(await _mediator.Send(new DeleteClientCommand
        {
            Data = id
        }));
}