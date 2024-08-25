using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ShippingRequestService.Domain.AggregatesModel;
using ShippingRequestService.Infrastructure.EntityConfiguraitons;

namespace ShippingRequestService.Infrastructure;

public class ShippingRequestDbContext : DbContext
{
    private readonly ILoggerFactory _loggerFactory;

    public ShippingRequestDbContext(
        DbContextOptions<ShippingRequestDbContext> options,
        ILoggerFactory loggerFactory) : base(options)
    {
        _loggerFactory = loggerFactory;
    }

    public DbSet<ShippingRequest> ShippingRequests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLoggerFactory(_loggerFactory);
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ShippingRequestEntityTypeConfiguration());
    }
}

public static class AppBuilderDatabaseExtensions
{
    public static void EnsureDatabase(this IApplicationBuilder app)
    {
        var context = app.ApplicationServices.GetService<ShippingRequestDbContext>();

        if (!context.Database.EnsureCreated())
            context.Database.Migrate();
    }
}
