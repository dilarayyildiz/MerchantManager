using MerchantApi.Services;

namespace MerchantApi.Extension;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectServices(this IServiceCollection services)
    {
        services.AddScoped<IMerchantService, FakeMerchantService>();
        services.AddScoped<IUserService, FakeUserService>();
        return services;
    }
}