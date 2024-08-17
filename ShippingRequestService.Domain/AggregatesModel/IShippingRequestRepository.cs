using ShippingRequestService.Domain.SeedWork;

namespace ShippingRequestService.Domain.AggregatesModel;

public interface IShippingRequestRepository : IRepository<ShippingRequest>
{
    Task Add(ShippingRequest shippingRequest);

    Task<ShippingRequest> GetAsync(int orderId);
}
