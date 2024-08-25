namespace ShippingRequestService.Domain.SeedWork;

public interface IUnitOfWork
{
    Task Commit();
}
