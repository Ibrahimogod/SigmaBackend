using SigmaBackend.Api;
using SigmaBackend.Api.Candidates;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers(cfg =>
{
    cfg.Filters.Add<GlobalValidator>();
});
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<CandidateMappingProfile>();
});

builder.Services
    .AddApplicationServices(configuration.GetConnectionString("SigmaDb")!);

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

var app = builder.Build();

app.UseExceptionHandler("/error");

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
