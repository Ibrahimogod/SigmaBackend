using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SigmaBackend.Infrastructure;

public class SigmaBackendDesignTimeDbContextFactory : IDesignTimeDbContextFactory<SigmaBackendDbContext>
{
    public SigmaBackendDbContext CreateDbContext(string[] args)
    {
        var dbContextOptionsBuilder = new DbContextOptionsBuilder<SigmaBackendDbContext>();
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("migrationsettings.json")
            .Build();
        var connectionString = configuration.GetConnectionString("SigmaDb");
        dbContextOptionsBuilder.UseNpgsql(connectionString);
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        return new SigmaBackendDbContext(dbContextOptionsBuilder.Options);
    }
}