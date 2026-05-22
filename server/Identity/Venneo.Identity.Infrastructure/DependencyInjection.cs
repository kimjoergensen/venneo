using Microsoft.Extensions.Hosting;

namespace Venneo.Identity.Infrastructure;

public static class DependencyInjection
{
    public static IHostApplicationBuilder AddInfrastructureServices(this IHostApplicationBuilder builder)
    {
        return builder;
    }
}
