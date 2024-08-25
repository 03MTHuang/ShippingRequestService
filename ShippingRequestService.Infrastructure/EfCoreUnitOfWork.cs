using ShippingRequestService.Domain.SeedWork;

namespace ShippingRequestService.Infrastructure;

public class EfCoreUnitOfWork : IUnitOfWork
{
    private readonly ShippingRequestDbContext _dbContext;

    public EfCoreUnitOfWork(ShippingRequestDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task Commit()
    {
        return _dbContext.SaveChangesAsync();
    }
}
