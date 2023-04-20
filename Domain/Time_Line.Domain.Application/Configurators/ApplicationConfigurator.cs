namespace Time_Line.Domain.Application.Configurators
{
    public static class ApplicationConfigurator
    {
        public static IServiceCollection LoadApplicationServicesConf(this IServiceCollection services)
        {
          
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
          
            services.AddTransient(typeof(IPipelineBehavior<,>),
            typeof(ValidationBehavior<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>),
            typeof(LoggingBehavior<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}