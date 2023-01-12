using AutoMapper;
using HotelComplex.CQRS.Abstractions.Models;
using HotelComplex.CQRS.Commands.Rooms;
using HotelComplex.CQRS.Queries.Rooms;
using HotelComplex.Hotel.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelComplex.Hotel.Controllers;

[ApiController]
[Route("api/rooms")]
public class RoomController : ControllerBase
{
    private IMediator _mediator;
    private IMapper _mapper;


    public RoomController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet("rooms")]
    public async Task<IEnumerable<RoomVm>> Get()
    {
        return _mapper.Map<IEnumerable<RoomVm>>(await _mediator.Send(new GetRoomsQuery()));
    }

    [HttpGet("{id}")]
    public async Task<RoomVm> Get(long id)
    {
        var result = await _mediator.Send(new GetRoomQuery()
        {
            Id = id
        });

        return _mapper.Map<RoomVm>(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] UpdateRoomVm model)
    {
        var result = await _mediator.Send(new AddRoomCommand()
        {
            Data = _mapper.Map<RoomDto>(model)
        });

        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<UpdateRoomVm>> Put([FromBody] RoomVm model)
    {
        var result = await _mediator.Send(new UpdateRoomCommand
        {
            Data = _mapper.Map<RoomDto>(model)
        });

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(long id)
    {
        var result = await _mediator.Send(new DeleteRoomCommand
        {
            Data = id
        });

        return Ok(result);
    }
}