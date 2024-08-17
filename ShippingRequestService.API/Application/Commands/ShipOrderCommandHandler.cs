using MediatR;

namespace ShippingRequestService.API.Application.Commands;

public class ShipOrderCommandHandler : IRequestHandler<ShipOrderCommand, bool>
{
    public Task<bool> Handle(ShipOrderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
