using Microsoft.EntityFrameworkCore.ChangeTracking;
using ShippingRequestService.Domain.AggregatesModel;

namespace ShippingRequestService.Infrastructure.Repositories;

public class ShippingRequestRepository : IShippingRequestRepository
{
    private readonly ShippingRequestDbContext _dbContext;

    public ShippingRequestRepository(ShippingRequestDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ValueTask<EntityEntry<ShippingRequest>> Add(ShippingRequest shippingRequest)
    {
        return _dbContext.ShippingRequests.AddAsync(shippingRequest);
    }

    public Task<ShippingRequest> GetAsync(int orderId)
    {
        throw new NotImplementedException();
    }
}
