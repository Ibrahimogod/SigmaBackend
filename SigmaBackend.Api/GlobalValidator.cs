using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SigmaBackend.Api;

public class GlobalValidator : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (!context.ModelState.IsValid)
        {
            context.Result = new BadRequestObjectResult(context.ModelState.ToList().Select(kvp => new
            {
                kvp.Key,
                Errors = kvp.Value?.Errors.Select(e => e.ErrorMessage)
            }));
            return;
        }

        await next();
    }
}