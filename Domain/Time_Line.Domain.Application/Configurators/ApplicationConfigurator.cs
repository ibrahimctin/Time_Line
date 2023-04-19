namespace Time_Line.Domain.Application.Configurators
{
    public static class ApplicationConfigurator
    {
        public static IServiceCollection LoadApplicationServicesConf(this IServiceCollection services)
        {
          
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped(typeof(IPipelineBehavior<,>),
            
       
               typeof(ValidationBehavior<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}