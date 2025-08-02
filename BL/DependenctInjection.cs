using OneProjectWebAPI.BL.Services;
using System.Runtime.CompilerServices;

namespace OneProjectWebAPI.BL;

public static class DependenctInjection
{
    public static IServiceCollection AddBL(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
