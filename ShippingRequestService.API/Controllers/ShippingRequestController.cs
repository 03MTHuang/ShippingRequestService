using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShippingRequestService.API.Application.Commands;

namespace ShippingRequestService.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShippingRequestController : ControllerBase
{
    private readonly IMediator _mediator;

    public ShippingRequestController(IMediator mediator)
    {
        this._mediator = mediator;
    }

    [HttpPost("RequestShipping")]
    public async Task<IActionResult> RequestShippingAsync([FromBody] RequestShippingCommand command)
    {
        var commandResult = await _mediator.Send(command);

        return commandResult ? Ok() : BadRequest();
    }
}
