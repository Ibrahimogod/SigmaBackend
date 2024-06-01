using Microsoft.EntityFrameworkCore;
using SigmaBackend.Domain.Models;
using SigmaBackend.Infrastructure;
using SigmaBackend.Infrastructure.Repositories;

namespace Microsoft.Extensions.DependencyInjection;

public static class Install
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString)
    {
        return services
            .AddSigmaBackendDbContext(connectionString)
            .AddRepositories();
    }

    private static IServiceCollection AddSigmaBackendDbContext(this IServiceCollection services, string connectionString)
    {
        return services.AddDbContext<SigmaBackendDbContext>(options =>
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            options.UseNpgsql(connectionString);
        });
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services
            .AddScoped<IRepository<Candidate>, CandidateRepository>();
    }
}