using ShippingRequestService.Domain.AggregatesModel;

namespace ShippingRequestService.Infrastructure.Repositories;

public class ShippingRequestRepository : IShippingRequestRepository
{
    public Task Add(ShippingRequest shippingRequest)
    {
        Console.WriteLine($"{shippingRequest.Id}, {shippingRequest.GetOrderId}, {shippingRequest.ShippingStatus}");

        return Task.CompletedTask;
    }

    public Task<ShippingRequest> GetAsync(int orderId)
    {
        throw new NotImplementedException();
    }
}
