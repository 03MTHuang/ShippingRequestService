using MediatR;
using ShippingRequestService.Domain.AggregatesModel;

namespace ShippingRequestService.API.Application.Commands;

public class RequestShippingCommandHandler : IRequestHandler<RequestShippingCommand, bool>
{
    private readonly IShippingRequestRepository _shippingRequestRepository;

    public RequestShippingCommandHandler(IShippingRequestRepository shippingRequestRepository)
    {
        this._shippingRequestRepository = shippingRequestRepository;
    }

    public async Task<bool> Handle(RequestShippingCommand request, CancellationToken cancellationToken)
    {
        var shippingRequest = new ShippingRequest(request.OrderId, request.ShippingAddress);

        await _shippingRequestRepository.Add(shippingRequest);

        return true;
    }
}
