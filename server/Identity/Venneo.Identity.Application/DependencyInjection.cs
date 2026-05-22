using Microsoft.Extensions.Hosting;

namespace Venneo.Identity.Application;

public static class DependencyInjection
{
    public static IHostApplicationBuilder AddApplicationServices(this IHostApplicationBuilder builder)
    {
        return builder;
    }
}
