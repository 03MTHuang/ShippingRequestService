using ShippingRequestService.Domain.Events;
using ShippingRequestService.Domain.SeedWork;

namespace ShippingRequestService.Domain.AggregatesModel;

public class ShippingRequest : Entity, IAggregateRoot
{
    public int GetOrderId => _orderId;
    private int _orderId;

    public ShippingStatus ShippingStatus { get; private set; }
    private int _shippingStatusId;

    private string _shippingAddress;
    private DateTime _createdAt;
    private DateTime? _deliveredAt;
    private DateTime? _failedAt;
    private string? _failureReason;

    public ShippingRequest(int orderId, string shippingAddress)
    {
        _orderId = orderId;
        _shippingAddress = shippingAddress;
        _createdAt = DateTime.Now;
        _shippingStatusId = ShippingStatus.Pending.Id;

        AddDomainEvent(new ShippingRequestedDomainEvent(this));
    }

    public void SetProcessingStatus()
    {
        _shippingStatusId = ShippingStatus.Processing.Id;
        AddDomainEvent(new OrderShippedDomainEvent(this));
    }
}
