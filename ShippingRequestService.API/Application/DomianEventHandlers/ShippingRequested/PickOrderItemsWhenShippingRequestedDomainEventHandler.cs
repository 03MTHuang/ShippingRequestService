using MediatR;
using ShippingRequestService.Domain.Events;

namespace ShippingRequestService.API.Application.DomianEventHandlers.ShippingRequested;

public class PickOrderItemsWhenShippingRequestedDomainEventHandler : INotificationHandler<ShippingRequestedDomainEvent>
{
    public Task Handle(ShippingRequestedDomainEvent notification, CancellationToken cancellationToken)
    {
        // 叫訂單揀貨


        throw new NotImplementedException();
    }
}
