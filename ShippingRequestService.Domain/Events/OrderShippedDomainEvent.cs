using MediatR;
using ShippingRequestService.Domain.AggregatesModel;

namespace ShippingRequestService.Domain.Events;

public class OrderShippedDomainEvent : INotification
{
    public ShippingRequest ShippingRequest { get; }

    public OrderShippedDomainEvent(ShippingRequest shippingRequest)
    {
        ShippingRequest = shippingRequest;
    }
}
