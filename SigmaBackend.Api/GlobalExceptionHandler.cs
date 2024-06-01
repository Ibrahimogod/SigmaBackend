using Microsoft.AspNetCore.Diagnostics;

namespace SigmaBackend.Api;

public class GlobalExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        httpContext.Response.StatusCode = 500;
        await httpContext.Response.WriteAsync("", cancellationToken: cancellationToken);
        return await Task.FromResult(true);
    }
}