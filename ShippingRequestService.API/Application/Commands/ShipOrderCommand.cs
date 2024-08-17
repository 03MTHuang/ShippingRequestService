using MediatR;

namespace ShippingRequestService.API.Application.Commands;

public class ShipOrderCommand : IRequest<bool>
{
}
