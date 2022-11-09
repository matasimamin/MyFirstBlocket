using Blocket.Business.Mappers;
using Blocket.Business.Services;
using Blocket.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Blocket.Business;

public static class ServiceCollectionExtension
{
    public static void AddBusiness(this IServiceCollection services)
    {
        services.AddSingleton<IItemMapper, ItemMapper>();
        services.AddSingleton<IItemService, ItemService>();
        services.AddRepository();
    }
}
