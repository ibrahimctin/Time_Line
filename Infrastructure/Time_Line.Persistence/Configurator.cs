namespace Time_Line.Persistence
{
    public static class Configurator
    {
        public static IServiceCollection LoadPersistenceServicesConf(this IServiceCollection services)
        {
            services.AddScoped(typeof(IReadRepository<>),
             typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>),
              typeof(WriteRepository<>));
            services.AddScoped<IPostReadRepository, PostReadRepository>();
            services.AddScoped<IPostWriteRepository, PostWriteRepository>();
            services.AddScoped<IPostService, PostService>();
            return services;
        }
    }
}
