using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Time_Line.Infrastructure.Identity.Services;

namespace QualificationExam.Identity.Configurators
{
    public static class IdentityServiceLayerConfigurator
    {
        public static IServiceCollection LoadIdentityServices (this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IJwtTokenService, JwtTokenService>();
            services.AddScoped<IRefreshTokenService, RefreshTokenService>();
        
            return services;
        }

    }
}
