using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShippingRequestService.Domain.AggregatesModel;

namespace ShippingRequestService.Infrastructure.EntityConfiguraitons;

internal class ShippingRequestEntityTypeConfiguration : IEntityTypeConfiguration<ShippingRequest>
{
    public void Configure(EntityTypeBuilder<ShippingRequest> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
