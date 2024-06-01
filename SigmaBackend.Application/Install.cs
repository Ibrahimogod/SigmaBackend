using SigmaBackend.Application.Candidates;
using SigmaBackend.Contract.Candidates;

namespace Microsoft.Extensions.DependencyInjection;

public static class Install
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, string connectionString)
    {
        return services
            .AddInfrastructureServices(connectionString)
            .AddScoped<ICandidateService, CandidateService>();
    }
}