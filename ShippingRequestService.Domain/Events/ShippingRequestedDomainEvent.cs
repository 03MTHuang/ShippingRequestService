using MediatR;
using ShippingRequestService.Domain.AggregatesModel;

namespace ShippingRequestService.Domain.Events;

public class ShippingRequestedDomainEvent : INotification
{
    public ShippingRequest ShippingRequest { get; }

    public ShippingRequestedDomainEvent(ShippingRequest shippingRequest)
    {
        ShippingRequest = shippingRequest;
    }
}
