using Microsoft.Extensions.DependencyInjection;

namespace Blocket.Data.Repository;

public static class ServiceCollectionExtension
{
    public static void AddRepository(this IServiceCollection services)
    {
        services.AddSingleton<IInMemItemsRepository, InMemItemsRepository>();
    }
}
