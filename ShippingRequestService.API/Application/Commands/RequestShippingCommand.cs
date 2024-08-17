using MediatR;

namespace ShippingRequestService.API.Application.Commands;

public class RequestShippingCommand : IRequest<bool>
{
    public int OrderId { get; private set; }
    public string ShippingAddress { get; private set; }

    public RequestShippingCommand(int orderId, string shippingAddress)
    {
        OrderId = orderId;
        ShippingAddress = shippingAddress;
    }
}
