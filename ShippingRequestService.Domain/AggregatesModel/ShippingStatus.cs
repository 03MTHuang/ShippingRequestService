using ShippingRequestService.Domain.SeedWork;

namespace ShippingRequestService.Domain.AggregatesModel;

public class ShippingStatus(int id, string name) : Enumeration(id, name)
{
    public static ShippingStatus Pending = new(1, nameof(Pending).ToLowerInvariant());
    public static ShippingStatus Processing = new(2, nameof(Processing).ToLowerInvariant());
    public static ShippingStatus Delivered = new(3, nameof(Delivered).ToLowerInvariant());
    public static ShippingStatus Failed = new(4, nameof(Failed).ToLowerInvariant());
}
